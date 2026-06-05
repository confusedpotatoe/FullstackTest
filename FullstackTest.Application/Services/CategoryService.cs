using FullstackTest.Application.DTOs;
using FullstackTest.Application.Interfaces;
using FullstackTest.Domain.Entities;

namespace FullstackTest.Application.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;

		// Krav: Dependency injection ska användas [1]
		public CategoryService(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		// Krav: API:et ska använda async/await [1]
		public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
		{
			var categories = await _categoryRepository.GetAllAsync();

			// Krav: DTO:s ska användas för responses [1]
			return categories.Select(c => new CategoryDto
			{
				Id = c.Id,
				Name = c.Name,
				Description = c.Description
			});
		}

		public async Task<CategoryDto> GetCategoryByIdAsync(int id)
		{
			var category = await _categoryRepository.GetByIdAsync(id);
			if (category == null) return null;

			return new CategoryDto
			{
				Id = category.Id,
				Name = category.Name,
				Description = category.Description
			};
		}

		public async Task CreateCategoryAsync(CreateCategoryDto categoryDto)
		{
			// Mappar från DTO (request) till Domän-entitet [1]
			var category = new Category
			{
				Name = categoryDto.Name,
				Description = categoryDto.Description
			};

			await _categoryRepository.AddAsync(category);
		}

		public async Task UpdateCategoryAsync(int id, UpdateCategoryDto categoryDto)
		{
			var category = await _categoryRepository.GetByIdAsync(id);
			if (category != null)
			{
				category.Name = categoryDto.Name;
				category.Description = categoryDto.Description;

				await _categoryRepository.UpdateAsync(category);
			}
		}
		public async Task DeleteCategoryAsync(int id)
		{
			await _categoryRepository.DeleteAsync(id);
		}
	}
}