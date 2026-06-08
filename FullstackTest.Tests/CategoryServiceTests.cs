using FullstackTest.Application.Interfaces;
using FullstackTest.Application.Services;
using FullstackTest.Domain.Entities;
using NSubstitute;

namespace FullstackTest.Tests
{
	public class CategoryServiceTests
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly CategoryService _sut;
		public CategoryServiceTests()
		{
			_categoryRepository = Substitute.For<ICategoryRepository>();
			_sut = new CategoryService(_categoryRepository);
		}

		[Fact]
		public async Task GetCategoryById_ShouldReturnCategoryDto_WhenCategoryExists()
		{
			// Arrange
			var categoryId = 1;
			var expectedCategory = new Category { Id = categoryId, Name = "Test Category" };
			_categoryRepository.GetByIdAsync(categoryId).Returns(expectedCategory);

			// Act
			var result = await _sut.GetCategoryByIdAsync(categoryId);

			// Assert
			Assert.NotNull(result);
			Assert.Equal(expectedCategory.Id, result.Id);
			Assert.Equal(expectedCategory.Name, result.Name);
		}

		[Fact]
		public async Task GetCategoryById_ShouldReturnNull_WhenCategoryDoesNotExist()
		{
			// Arrange
			var categoryId = 1;
			_categoryRepository.GetByIdAsync(categoryId).Returns((Category)null);

			// Act
			var result = await _sut.GetCategoryByIdAsync(categoryId);

			// Assert
			Assert.Null(result);
		}

		[Fact]
		public async Task GetAllCategories_ShouldReturnEmptyList_WhenNoCategoriesExist()
		{
			// Arrange
			_categoryRepository.GetAllAsync().Returns(new List<Category>());

			// Act
			var result = await _sut.GetAllCategoriesAsync();

			// Assert
			Assert.NotNull(result);
			Assert.Empty(result);
		}
	}
}
