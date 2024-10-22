using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.BrandDtos;
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
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerService _loggerService;
        private readonly IMapper _mapper;
        private readonly ICloudinaryService _cloudinaryService;

        public BrandService(IUnitOfWork unitOfWork,
                            ILoggerService loggerService,
                            IMapper mapper,
                            ICloudinaryService cloudinaryService
        )
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
            _mapper = mapper;
            _cloudinaryService = cloudinaryService;
        }

        public async Task<IEnumerable<BrandDto>> GetAllBrandAsync()
        {
            var brands = await _unitOfWork.BrandRepository.GetAllAsync(false);

            return _mapper.Map<IEnumerable<BrandDto>>( brands);
        }

        public async Task<BrandDto> GetBrandByIdAsync(int id)
        {
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id);

            if(brand == null)
            {
                throw new BrandNotFoundException(id);
            }

            return _mapper.Map<BrandDto>( brand);
        }

        public async Task<BrandDto> CreateBrandAsync(BrandForCreateDto brandForCreateDto)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var brand = _mapper.Map<Brand>(brandForCreateDto);
                await _unitOfWork.BrandRepository.AddAsync(brand);
                await _unitOfWork.SaveChangesAsync();

                

                if(brandForCreateDto.LogoFile != null)
                {
                    string folder = $"HomeDecor/{CloudinaryConstants.Folders.Brand}/${brand.Id}";
                    string imageUrl = await _cloudinaryService.UploadImageAsync(brandForCreateDto.LogoFile, folder, CloudinaryConstants.FileTypes.BrandImage);
                    brand.LogoUrl = imageUrl;
                    _unitOfWork.BrandRepository.Update(brand);
                }
                await _unitOfWork.CommitAsync();

                _loggerService.LogInfo($"Brand mới được tạo với ID: {brand.Name}");
                return _mapper.Map<BrandDto>(brand);
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _loggerService.LogError($"Lỗi khi tạo Brand: {ex.Message}");
                throw;
            }                
        }

        public async Task<BrandDto> UpdateBrandAsync(int id, BrandForUpdateDto brandForUpdateDto)
        {
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id);
            if(brand != null)
            {
                _loggerService.LogError($"Không tim thấy Brand ID: {id}");
                throw new BrandNotFoundException(id);
            } 
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                _mapper.Map(brandForUpdateDto, brand);
                if(brandForUpdateDto.LogoFile != null)
                {
                    string folder = $"HomeDecor/{CloudinaryConstants.Folders.Brand}";
                    string oldPublicId = _cloudinaryService.GetPublicIdFromUrl(brand.LogoUrl);

                    brand.LogoUrl = await _cloudinaryService.ReplaceImageAsync(brandForUpdateDto.LogoFile, oldPublicId, folder, CloudinaryConstants.FileTypes.BrandImage);
                }

                _unitOfWork.BrandRepository.Update(brand);
                await _unitOfWork.CommitAsync();

                return _mapper.Map<BrandDto>(brand);
            }
            catch(Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _loggerService.LogError($"Lỗi khi Update Brand: {ex.Message}");
                throw;
            }
                
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id);
            if (brand != null)
            {
                _loggerService.LogError($"Không tim thấy Brand ID: {id}");
                throw new BrandNotFoundException(id);
            }

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
