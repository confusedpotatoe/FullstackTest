using FullstackTest.Application.Interfaces;
using FullstackTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullstackTest.Infrastructure.Repositories
{
	public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
	{
		public CategoryRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Category>> GetCategoriesWithProductsAsync()
		{
			return await _context.Categories
				.Include(c => c.Products)
				.ToListAsync();
		}
	}
}