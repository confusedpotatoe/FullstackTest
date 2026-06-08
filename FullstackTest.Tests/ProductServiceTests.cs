using FullstackTest.Application.DTOs;
using FullstackTest.Application.Interfaces;
using FullstackTest.Application.Services;
using FullstackTest.Domain.Entities;
using NSubstitute;

namespace FullstackTest.Tests
{
	public class ProductServiceTests
	{
		private readonly IProductRepository _productRepository;
		private readonly ProductService _sut;
		public ProductServiceTests()
		{
			_productRepository = Substitute.For<IProductRepository>();
			_sut = new ProductService(_productRepository);
		}

		[Fact]
		public async Task GetProductById_ShouldReturnProductDto_WhenProductExists()
		{
			// Arrange
			var productId = 1;
			var expectedProduct = new Product { Id = productId, Name = "Test Product", Price = 10.99m };
			_productRepository.GetByIdAsync(productId).Returns(expectedProduct);

			// Act
			var result = await _sut.GetProductByIdAsync(productId);

			// Assert
			Assert.NotNull(result);
			Assert.Equal(expectedProduct.Id, result.Id);
			Assert.Equal(expectedProduct.Name, result.Name);
			Assert.Equal(expectedProduct.Price, result.Price);
		}

		[Fact]
		public async Task GetProductById_ShouldReturnNull_WhenProductDoesNotExist()
		{
			// Arrange
			var productId = 1;
			var expectedProduct = new Product { Id = productId, Name = "BestTEST", Price = 15000 };
			_productRepository.GetByIdAsync(productId).Returns(expectedProduct);
			// Act
			var result = await _sut.GetProductByIdAsync(productId);
			// Assert
			Assert.Null(result);
		}

		[Fact]
		public async Task CreateProduct_ShouldCallAddAsync_WhenDataIsValid()
		{
			// Arrange
			var createDto = new CreateProductDto { Name = "Test Product", Price = 10.99m, CategoryId = 1 };
			// Act
			await _sut.CreateProductAsync(createDto);
			// Assert
			await _productRepository.Received(1).AddAsync(Arg.Any<Product>());
		}

		[Fact]
		public async Task GetProductsByCategoryId_ShouldReturnList_WhenCategoryHasProducts()
		{
			// Arrange
			var categoryId = 1;
			var products = new List<Product> { new Product { Id = 1, Name = "Test Product", CategoryId = categoryId } };
			_productRepository.GetProductsByCategoryIdAsync(categoryId).Returns(products);

			// Act
			var result = await _sut.GetProductsByCategoryIdAsync(categoryId);

			// Assert
			Assert.Single(result);
		}
	}
}
