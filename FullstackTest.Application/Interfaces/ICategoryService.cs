using FullstackTest.Application.DTOs;

namespace FullstackTest.Application.Interfaces
{
	public interface ICategoryService
	{
		Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
		Task<CategoryDto> GetCategoryByIdAsync(int id);
		Task CreateCategoryAsync(CreateCategoryDto categoryDto);
		Task UpdateCategoryAsync(int id, UpdateCategoryDto categoryDto);
		Task DeleteCategoryAsync(int id);

	}
}
