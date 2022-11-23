using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
	public class ProductSeed: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Product() { Id=1,Name="Kalem 1",CategoryId=1,Price=100,Stock=20,CreatedDate=DateTime.Now},
                new Product() { Id = 2, Name = "Kalem 1", CategoryId = 1, Price = 200, Stock = 20, CreatedDate = DateTime.Now },
                new Product() { Id = 3, Name = "Kalem 1", CategoryId = 1, Price = 300, Stock = 20, CreatedDate = DateTime.Now },
                new Product() { Id = 4, Name = "Kitap 1", CategoryId = 2, Price = 400, Stock = 20, CreatedDate = DateTime.Now },
                new Product() { Id = 5, Name = "Kitap 2", CategoryId = 2, Price = 500, Stock = 20, CreatedDate = DateTime.Now }
            );
        }
    }
}

