using FullstackTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullstackTest.Infrastructure
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seedning av kategorier
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Elektronik", Description = "Prylar och teknik" },
				new Category { Id = 2, Name = "Hem & Inredning", Description = "Saker för hemmet" }
			);

			// Konfigurera precision för decimal-egenskapen Price
			modelBuilder.Entity<Product>()
				.Property(p => p.Price)
				.HasColumnType("decimal(18,2)"); // 18 siffror totalt, 2 efter decimalen

			// Din befintliga relationskonfiguration
			modelBuilder.Entity<Product>()
				.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryId);
		}
	}
}
