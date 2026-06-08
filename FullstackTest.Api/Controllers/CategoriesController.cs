using FullstackTest.Application.DTOs;
using FullstackTest.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FullstackTest.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}
		[HttpGet]
		public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAll()
		{
			var categories = await _categoryService.GetAllCategoriesAsync();
			return Ok(categories);
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<CategoryDto>> GetById(int id)
		{
			var category = await _categoryService.GetCategoryByIdAsync(id);
			if (category == null)
			{
				return NotFound();
			}
			return Ok(category);
		}
		[HttpPost]
		public async Task<ActionResult> Create(CreateCategoryDto createDto)
		{
			await _categoryService.CreateCategoryAsync(createDto);
			return Ok();
		}
		[HttpPut("{id}")]
		public async Task<ActionResult> Update(int id, UpdateCategoryDto updateDto)
		{
			await _categoryService.UpdateCategoryAsync(id, updateDto);
			return Ok();
		}
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			await _categoryService.DeleteCategoryAsync(id);
			return Ok();
		}
	}
}
