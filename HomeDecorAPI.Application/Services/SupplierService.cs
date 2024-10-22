using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.SupplierDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<SupplierDto>> GetAllSupplierAsync()
        {
            var suppliers = await _unitOfWork.SupplierRepository.GetAllAsync(false);

            return _mapper.Map<IEnumerable<SupplierDto>>(suppliers);
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
                    string folder = $"HomeDecor/${CloudinaryConstants.Folders.Supplier}/${supplier.Id}";
                    string imageUrl = await _cloudinaryService.UploadImageAsync(supplierForCreateDto.LogoFile, folder, CloudinaryConstants.FileTypes.Supplier);

                    supplier.LogoUrl = imageUrl;
                    _unitOfWork.SupplierRepository.Update(supplier);
                   await  _unitOfWork.SaveChangesAsync();
                }
                await _unitOfWork.CommitAsync();

                return _mapper.Map<SupplierDto>(supplier);

            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _loggerService.LogError("Có lỗi sảy ra trong quá trình tạo mới một Supplier.");
                throw;
            }
        }
    }
}
