using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;

namespace NLayer.Repository
{
	public class AppDbContext: DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
		{
			
		}

        public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductFeature> ProductFeatures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			//Bütün configurationları ları uygular.
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			// Fluent API deniyor => modelBuilder.Entity<Category>().HasKey(x => x.Id);
			modelBuilder.Entity<ProductFeature>().HasData(
				new ProductFeature()
				{
					Id=1,
					Color="Kırmızı",
					Height=100,
					Width=200,
					ProductId=1
				},
                new ProductFeature()
                {
                    Id = 2,
                    Color = "Mavi",
                    Height = 300,
                    Width = 500,
                    ProductId = 2
                }
            );
			base.OnModelCreating(modelBuilder);
        }
    }
}

