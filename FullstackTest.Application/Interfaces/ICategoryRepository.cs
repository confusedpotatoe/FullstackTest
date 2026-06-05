using FullstackTest.Domain.Entities;

namespace FullstackTest.Application.Interfaces
{
	public interface ICategoryRepository : IGenericRepository<Category>
	{
		Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
	}
}