using FullstackTest.Application.DTOs;
using FullstackTest.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FullstackTest.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;
		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}
		[HttpGet]
		public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
		{
			var products = await _productService.GetAllProductsAsync();
			return Ok(products);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<ProductDto>> GetById(int id)
		{
			var product = await _productService.GetProductByIdAsync(id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}

		[HttpPost]
		public async Task<ActionResult> Create(CreateProductDto createDto)
		{
			await _productService.CreateProductAsync(createDto);
			return Ok();
		}

		[HttpPut("{id}")]
		public async Task<ActionResult> Update(int id, UpdateProductDto updateDto)
		{
			await _productService.UpdateProductAsync(id, updateDto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			await _productService.DeleteProductAsync(id);
			return Ok();
		}
	}
}
