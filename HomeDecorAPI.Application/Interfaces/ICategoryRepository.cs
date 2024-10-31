using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface ICategoryRepository : IRepositoryBase<Category> {
        Task<ICollection<Category>> GetSubcategoriesByParentCategory(int parentCategoryId);
        Task<PagedList<Category>> GetAllCategories(CategoryRequestParameters categoryRequestParameters);
    }
}
