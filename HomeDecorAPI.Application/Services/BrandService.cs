﻿using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.BrandDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public async Task<(IEnumerable<BrandDto> brands, MetaData metaData)> GetAllBrandAsync(BrandRequestParameters brandRequestParameters)
        {

           var brandsWithMetaData = await _unitOfWork.BrandRepository.getAllSupplierAsync(brandRequestParameters);
           
            var brandsDto = _mapper.Map<IEnumerable<BrandDto>>(brandsWithMetaData);
            return (brands: brandsDto, metaData: brandsWithMetaData.MetaData);
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
                    string folder = $"HomeDecor/{CloudinaryConstants.Folders.Brand}/ID{brand.Id}/";
                    string imageUrl = await _cloudinaryService.UploadImageAsync(brandForCreateDto.LogoFile, folder, CloudinaryConstants.FileTypes.BrandImage);
                    brand.LogoUrl = imageUrl;
                    _unitOfWork.BrandRepository.Update(brand);
                    _loggerService.LogInfo($"Upload Image thành công với URL: {imageUrl}");
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
            if(brand == null)
            {
                _loggerService.LogError($"Không tim thấy Brand ID: {id}");
                throw new BrandNotFoundException(id);
            } 
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                _mapper.Map(brandForUpdateDto, brand);
                await _unitOfWork.SaveChangesAsync();
                if(brandForUpdateDto.LogoFile != null)
                {
                    string folder = $"HomeDecor/{CloudinaryConstants.Folders.Brand}/ID{brand.Id}/";
                    string oldPublicId = _cloudinaryService.GetPublicIdFromUrl(brand.LogoUrl);
                    brand.LogoUrl = await _cloudinaryService.ReplaceImageAsync(brandForUpdateDto.LogoFile, oldPublicId, folder, CloudinaryConstants.FileTypes.BrandImage);
                    _loggerService.LogInfo($"Cập nhật hình ảnh mới cho Brand thành công với URL: {brand.LogoUrl}");
                }else if(brandForUpdateDto.isDeleteImage && brand.LogoUrl != null)
                {
                    var publicId = _cloudinaryService.GetPublicIdFromUrl(brand.LogoUrl);
                    await _cloudinaryService.DeleteImageAsync(publicId);
                    brand.LogoUrl = null;
                    _loggerService.LogInfo($"Xóa thành công Image Brand với PublicId: {publicId}");
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
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id);
                if (brand == null)
                {
                    _loggerService.LogError($"Không tim thấy Brand ID: {id}");
                    throw new BrandNotFoundException(id);
                }

                if(brand.LogoUrl != null)
                {
                    string publicId = _cloudinaryService.GetPublicIdFromUrl(brand.LogoUrl);
                    await _cloudinaryService.DeleteImageAsync(publicId);
                    _loggerService.LogInfo($"Xóa thành công Image Brand với PublicId: {publicId}");
                }
                _unitOfWork.BrandRepository.Remove(brand);
                await _unitOfWork.CommitAsync();
            }
            catch(Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _loggerService.LogError($"Có vấn đề sảy ra khi thực hiện xóa Brand với ID: {id}");
                throw ex;
            }
        }
    }
}
