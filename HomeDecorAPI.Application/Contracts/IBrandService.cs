using HomeDecorAPI.Application.DTOs.BrandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandDto>> GetAllBrandAsync();
        Task<BrandDto> GetBrandByIdAsync(int id);
        Task<BrandDto> CreateBrandAsync(BrandForCreateDto brandForCreateDto);
        Task<BrandDto> UpdateBrandAsync(int id, BrandForUpdateDto brandForUpdateDto);
        Task DeleteBrandAsync(int id);
    }
}
