using FullstackTest.Application.DTOs;
using FullstackTest.Application.Interfaces;
using FullstackTest.Domain.Entities;

namespace FullstackTest.Application.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;

		// Dependency injection används för att ta in repository-interfacet [1, 2]
		public ProductService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		// Krav: Sida för att visa data från API:t (Read) [4]
		public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
		{
			var products = await _productRepository.GetAllAsync();

			// Mappar domän-entiteter till DTO:er för response [1]
			return products.Select(p => new ProductDto
			{
				Id = p.Id,
				Name = p.Name,
				Price = p.Price,
				CategoryId = p.CategoryId
			});
		}

		public async Task<ProductDto> GetProductByIdAsync(int id)
		{
			var product = await _productRepository.GetByIdAsync(id);
			if (product == null) return null;

			return new ProductDto
			{
				Id = product.Id,
				Name = product.Name,
				Price = product.Price,
				CategoryId = product.CategoryId
			};
		}

		// Krav: Formulär för att skapa ny data (Create) [4]
		public async Task CreateProductAsync(CreateProductDto productDto)
		{
			var product = new Product
			{
				Name = productDto.Name,
				Price = productDto.Price,
				CategoryId = productDto.CategoryId
			};

			await _productRepository.AddAsync(product);
		}

		// Krav: Funktion för att uppdatera data (Update) [4]
		public async Task UpdateProductAsync(int id, UpdateProductDto productDto)
		{
			var product = await _productRepository.GetByIdAsync(id);
			if (product != null)
			{
				product.Name = productDto.Name;
				product.Price = productDto.Price;
				product.CategoryId = productDto.CategoryId;

				await _productRepository.UpdateAsync(product);
			}
		}

		// Krav: Funktion för att ta bort data (Delete) [4]
		public async Task DeleteProductAsync(int id)
		{
			await _productRepository.DeleteAsync(id);
		}
	}
}