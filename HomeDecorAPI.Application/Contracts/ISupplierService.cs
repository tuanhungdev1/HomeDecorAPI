using HomeDecorAPI.Application.DTOs.SupplierDtos;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts
{
    public interface ISupplierService
    {
        Task<(IEnumerable<SupplierDto> suppliers, MetaData metaData)> GetAllSupplierAsync(SupplierRequestParameters supplierRequestParameters);
        Task<SupplierDto> GetSupplierByIdAsync(int id);
        Task<SupplierDto> CreateSupplierAsync(SupplierForCreateDto supplierForCreateDto);
        Task<SupplierDto> UpdateSupplierAsync(int supplierId, SupplierForUpdateDto supplierForUpdateDto);
        Task DeleteSupplierAsync(int id);
    }
}
