using FullstackTest.Application.Interfaces;
using FullstackTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullstackTest.Infrastructure.Repositories
{
	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
		public ProductRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
		{
			return await _context.Products
				.Where(p => p.CategoryId == categoryId)
				.ToListAsync();
		}

		public async Task<IEnumerable<Product>> GetProductsByIdAsync(IEnumerable<int> productIds)
		{
			return await _context.Products
				.Where(p => productIds.Contains(p.Id))
				.ToListAsync();
		}

		public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
		{
			return await _context.Products
				.Where(p => p.Name.Contains(name))
				.ToListAsync();
		}

		public async Task<IEnumerable<Product>> GetProductsWithCategoriesAsync()
		{
			return await _context.Products
				.Include(p => p.Category)
				.ToListAsync();
		}
	}
}