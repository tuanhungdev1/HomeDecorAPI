using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.Utilities
{
    public static class EntityLoaderUtil
    {
        public static async Task LoadNestedEntitiesAsync<T>(
            DbContext context,
            T entity,
            Expression<Func<T, ICollection<T>>> subEntitySelector) where T : class
        {
            if (entity == null || context == null || subEntitySelector == null)
                throw new ArgumentException("Context, entity or subEntitySelector cannot be null.");

            // Lấy tên của property từ expression
            string propertyName = GetPropertyName(subEntitySelector);

            await context.Entry(entity)
                .Collection(propertyName)
                .LoadAsync();

            var compiledSelector = subEntitySelector.Compile();
            foreach (var subEntity in compiledSelector(entity))
            {
                await LoadNestedEntitiesAsync(context, subEntity, subEntitySelector);
            }
        }

        private static string GetPropertyName<T, TProperty>(Expression<Func<T, TProperty>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }

            throw new ArgumentException("Expression must be a member expression");
        }
    }
}