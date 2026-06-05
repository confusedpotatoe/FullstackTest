using FullstackTest.Application.DTOs;

namespace FullstackTest.Application.Interfaces
{
	public interface IProductService
	{
		Task<IEnumerable<ProductDto>> GetAllProductsAsync();

		Task<ProductDto> GetProductByIdAsync(int id);

		Task CreateProductAsync(CreateProductDto productDto);

		Task UpdateProductAsync(int id, UpdateProductDto productDto);

		Task DeleteProductAsync(int id);
	}
}