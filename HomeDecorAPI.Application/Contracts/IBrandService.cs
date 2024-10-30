using HomeDecorAPI.Application.DTOs.BrandDtos;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts
{
    public interface IBrandService
    {
        Task<(IEnumerable<BrandDto> brands, MetaData metaData)> GetAllBrandAsync(BrandRequestParameters brandRequestParameters);
        Task<BrandDto> GetBrandByIdAsync(int id);
        Task<BrandDto> CreateBrandAsync(BrandForCreateDto brandForCreateDto);
        Task<BrandDto> UpdateBrandAsync(int id, BrandForUpdateDto brandForUpdateDto);
        Task DeleteBrandAsync(int id);
    }
}
