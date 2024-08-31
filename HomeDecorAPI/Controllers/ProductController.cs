using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace HomeDecorAPI.Presentation.Controllers {

    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase {

        private readonly IServiceManager _serviceManager;

        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }


        [HttpGet]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAllProductAsync([FromBody] ProductRequestParameters productRequestParameters) {
            var (pagedList, metaData) = await _serviceManager.ProductService.GetAllProductsAsync(productRequestParameters.PageNumber, productRequestParameters.PageSize);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(new {
                totalCount = pagedList.Count(),
                pageSize = metaData.PageSize,
                currentPage = metaData.CurrentPage,
                totalPages = metaData.TotalPage
            }));

            return Ok(new ApiResponse<IEnumerable<ProductDto>>(
                isSuccess: true,
                message: Messages.Success.DataRetrieved,
                data: pagedList
            ));
        }
    }
}
