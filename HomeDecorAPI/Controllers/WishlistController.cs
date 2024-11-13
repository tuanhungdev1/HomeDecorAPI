using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.WishlistDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HomeDecorAPI.Presentation.Controllers {
	[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase {

        private readonly IWishlistService _wishlistService;
        private readonly ILoggerService _loggerService;

        public WishlistController(IWishlistService wishlistService, ILoggerService loggerService)
        {
			_wishlistService = wishlistService;
			_loggerService = loggerService;
        }


        [HttpGet]
		public async Task<IActionResult> GetWishlist([FromQuery] WishlistRequestParameters parameters)
        {
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var result = await _wishlistService.GetUserWishlistAsync(userId, parameters);
            _loggerService.LogInfo($"Lấy danh sách yêu thích của USER với UserId:{userId} thành công");
            Response.AddPaginationHeader(result.MetaData);
			return Ok(new ApiResponse<(IEnumerable<WishlistItemDto>, MetaData)>
			{
				Success = true,
				Data = result,
				StatusCode = 200,
				Message = "Retrieved wishlist successfully"
			});
		}


		[HttpPost]
		public async Task<IActionResult> AddToWishlist([FromBody] AddToWishlistDto request)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var result = await _wishlistService.AddToWishlistAsync(userId, request.ProductVariantId);
			_loggerService.LogInfo($"Thêm một sản phẩm vào danh sách yêu thích của User với UserId:{userId}");
			return Ok(new ApiResponse<WishlistItemDto>
			{
				Success = true,
				StatusCode = 200,
				Data = result,
				Message = "Added to wishlist successfully"
			});
		}

		[HttpDelete("{productId}")]
		public async Task<IActionResult> RemoveFromWishlist(int productId)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			await _wishlistService.RemoveFromWishlistAsync(userId, productId);
			_loggerService.LogInfo($"Xóa thành công sản phẩm trong danh mục yêu thích của UserId:{userId}");
			return Ok(new ApiResponse<string>
			{
				Success = true,
				StatusCode = 200,
				Message = "Removed from wishlist successfully"
			});
		}

		[HttpDelete]
		public async Task<IActionResult> ClearWishlist()
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			await _wishlistService.ClearWishlistAsync(userId);
			_loggerService.LogInfo($"Xóa thành công tất cả các sản phảm yêu thích của người dùng.");
			return Ok(new ApiResponse<string>
			{
				Success = true,
				StatusCode = 200,
				Message = "Wishlist cleared successfully"
			});
		}


		[HttpGet("check/{productId}")]
		public async Task<IActionResult> CheckInWishlist(int productId)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var result = await _wishlistService.CheckInWishlistAsync(userId, productId);
			_loggerService.LogInfo($"Kiểm tra sản phẩm bên trong danh mục yêu thích thành công.");
			return Ok(new ApiResponse<bool>
			{
				StatusCode = 200,
				Success = true,
				Data = result,
				Message = "Checked wishlist successfully"
			});
		}

	}
}
