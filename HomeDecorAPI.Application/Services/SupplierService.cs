using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.SupplierDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;

namespace HomeDecorAPI.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerService _loggerService;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IMapper _mapper;
        public SupplierService(IUnitOfWork unitOfWork,
                               ILoggerService loggerService,
                               ICloudinaryService cloudinaryService,
                               IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
            _cloudinaryService = cloudinaryService;
            _mapper = mapper;
        }

        public async Task<(IEnumerable<SupplierDto> suppliers, MetaData metaData)> GetAllSupplierAsync(SupplierRequestParameters supplierRequestParameters)
        {
            var suppliers = await _unitOfWork.SupplierRepository.GetAllSupplierAsync(supplierRequestParameters);

            var supplierDtos = _mapper.Map<IEnumerable<SupplierDto>>( suppliers);
            return (suppliers: supplierDtos, metaData: suppliers.MetaData);
        }


        public async Task<SupplierDto> GetSupplierByIdAsync(int id)
        {
            var suppliers = await _unitOfWork.SupplierRepository.GetByIdAsync(id);

            if(suppliers == null)
            {
                _loggerService.LogError("Không tìm thấy nhà cung cấp trong database.");
                throw new SupplierNotFoundException(id);
            }

            return _mapper.Map<SupplierDto>(suppliers);
        }

        public async Task<SupplierDto> CreateSupplierAsync(SupplierForCreateDto supplierForCreateDto)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var supplier = _mapper.Map<Supplier>(supplierForCreateDto);
                await _unitOfWork.SupplierRepository.AddAsync(supplier);
                await _unitOfWork.SaveChangesAsync();

                if(supplierForCreateDto.LogoFile != null)
                {
                    string folder = $"HomeDecor/{CloudinaryConstants.Folders.Supplier}/{supplier.Id}";
                    string imageUrl = await _cloudinaryService.UploadImageAsync(supplierForCreateDto.LogoFile, folder, CloudinaryConstants.FileTypes.Supplier);
                    
                    supplier.LogoUrl = imageUrl;
                    _loggerService.LogInfo($"Cập nhật thành công ảnh cho Supplier với ID: {supplier.Id}");
                }

                _unitOfWork.SupplierRepository.Update(supplier);
                await _unitOfWork.CommitAsync();
                _loggerService.LogInfo($"Tạo thành công một Supplier với ID: {supplier.Id}");
                return _mapper.Map<SupplierDto>(supplier);

            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _loggerService.LogError("Có lỗi sảy ra trong quá trình tạo mới một Supplier.");
                throw;
            }
        }

        public async Task<SupplierDto> UpdateSupplierAsync(int supplierId, SupplierForUpdateDto supplierForUpdateDto)
        {
            var supplier = await _unitOfWork.SupplierRepository.GetByIdAsync(supplierId);
            if(supplier == null)
            {
                _loggerService.LogError($"Không tìm thấy Supplier với ID: {supplierId}");
                throw new SupplierNotFoundException(supplierId);
            }
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                _mapper.Map(supplierForUpdateDto, supplier);
                _unitOfWork.SupplierRepository.Update(supplier);
                await _unitOfWork.SaveChangesAsync();

                if (supplierForUpdateDto.LogoFile != null)
                {
                    string folder = $"HomeDecor/{CloudinaryConstants.Folders.Supplier}/{supplier.Id}";
                    string oldPublicId =  _cloudinaryService.GetPublicIdFromUrl(supplier.LogoUrl);
                    supplier.LogoUrl = await _cloudinaryService.ReplaceImageAsync(supplierForUpdateDto.LogoFile, oldPublicId, folder, CloudinaryConstants.FileTypes.Supplier);
                    _loggerService.LogInfo($"Upload thành công ảnh của Supplier với URL: {supplier.LogoUrl}");
                } else if(supplier.LogoUrl != null && supplierForUpdateDto.IsDeleteImage)
                {
                    string publicId = _cloudinaryService.GetPublicIdFromUrl(supplier.LogoUrl);
                    await _cloudinaryService.DeleteImageAsync(publicId);
                    _loggerService.LogInfo($"Xóa thành công ảnh của Supplier với ID: {supplier.Id}");
                    supplier.LogoUrl = null;
                }
                _unitOfWork.SupplierRepository.Update(supplier);
                await _unitOfWork.CommitAsync();
                _loggerService.LogInfo("Cập nhật thông tin Supplier thành công.");
                return _mapper.Map<SupplierDto>(supplier);
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _loggerService.LogError("Có lỗi sảy ra trong quá trình thực thi.");
                throw;
            }
        }

        public async Task DeleteSupplierAsync(int id)
        {

            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var supplier = await _unitOfWork.SupplierRepository.GetByIdAsync(id);
                if (supplier == null)
                {
                    _loggerService.LogError($"Không tìm thấy Supplier với ID: {id}");
                    throw new SupplierNotFoundException(id);
                }
                if(supplier.LogoUrl != null)
                {
                    var publicId = _cloudinaryService.GetPublicIdFromUrl(supplier.LogoUrl);
                    await _cloudinaryService.DeleteImageAsync(publicId);
                    _loggerService.LogInfo($"Xóa thành công ảnh của Supplier với ID: {id}");
                }
                _unitOfWork.SupplierRepository.Remove(supplier);
                await _unitOfWork.CommitAsync();
            }
            catch(Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _loggerService.LogError($"Có lỗi sảy ra, Không thể xóa Supplier với ID: {id}");
                throw ex;
            }
        }
    }
}
