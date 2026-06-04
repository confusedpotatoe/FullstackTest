using FullstackTest.Domain.Entities;

namespace FullstackTest.Application.Interfaces
{
	public interface IProductRepository : IGenericRepository<Product>
	{
		Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);
		Task<IEnumerable<Product>> GetProductsByIdAsync(IEnumerable<int> productIds);
		Task<IEnumerable<Product>> GetProductsByNameAsync(string name);

	}
}
