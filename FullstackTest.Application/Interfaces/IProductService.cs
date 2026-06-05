using FullstackTest.Application.DTOs;

namespace FullstackTest.Application.Interfaces
{
	public interface IProductService
	{
		// Krav: Sida för att visa data från API:t (Read) [3]
		Task<IEnumerable<ProductDto>> GetAllProductsAsync();

		Task<ProductDto> GetProductByIdAsync(int id);

		// Krav: Formulär för att skapa ny data (Create) [3]
		Task CreateProductAsync(CreateProductDto productDto);

		// Krav: Funktion för att uppdatera data (Update) [3]
		Task UpdateProductAsync(int id, UpdateProductDto productDto);

		// Krav: Funktion för att ta bort data (Delete) [3]
		Task DeleteProductAsync(int id);
	}
}