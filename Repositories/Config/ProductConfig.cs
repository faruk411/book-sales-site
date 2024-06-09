using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(  p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1,  CategoryId = 2, ImageUrl = "/images/1.jpg", ProductName = "Computer", Price = 17000 , Vitrin = false},
                new Product() { ProductId = 2,  CategoryId = 2, ImageUrl = "/images/2.jpg", ProductName = "Keybord", Price = 1700, Vitrin = false },
                new Product() { ProductId = 3,  CategoryId = 2, ImageUrl = "/images/3.jpg", ProductName = "Mouse", Price = 700 , Vitrin = false },
                new Product() { ProductId = 4,  CategoryId = 2, ImageUrl = "/images/4.jpg", ProductName = "Monitor", Price = 4000, Vitrin = false },
                new Product() { ProductId = 5,  CategoryId = 2, ImageUrl = "/images/5.jpg", ProductName = "Deck", Price = 1000 , Vitrin = false },
                new Product() { ProductId = 6,  CategoryId = 1, ImageUrl = "/images/6.jpg", ProductName = "History Book", Price = 50, Vitrin = false },
                new Product() { ProductId = 7,  CategoryId = 2, ImageUrl = "/images/osmanlı.jpg", ProductName = "Ottoman History", Price = 75 , Vitrin = false },
                new Product() { ProductId = 8,  CategoryId = 2, ImageUrl = "/images/algoritma.jpg", ProductName = "Algoritma", Price = 300, Vitrin = true },
                new Product() { ProductId = 9,  CategoryId = 2, ImageUrl = "/images/yapay_zeka.jpg", ProductName = "Yapay Zeka", Price = 250 , Vitrin = true },
                new Product() { ProductId = 10, CategoryId = 2, ImageUrl = "/images/mühendislik.jpg", ProductName = "Yazılım Mühendisliği", Price = 350, Vitrin = true }
                );
        }
    }
}
