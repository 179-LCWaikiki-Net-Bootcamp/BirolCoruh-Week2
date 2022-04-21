using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasData(
             new Product { Id = 1, CategoryId = 2, Name = "LCW CLASSIC Dar Kalıp Gabardin Erkek Chino Pantolon", Price = 169, Stock = 150, Description = "Gabardin kumaştan" },
             new Product { Id = 2, CategoryId = 2, Name = "LCW CASUAL Slim Fit Gabardin Erkek Kargo Pantolon", Price = 200, Stock = 100, Description = "Beli lastikli ayarlanabilir ipli" },
             new Product { Id = 3, CategoryId = 1, Name = "LCW CASUAL Bisiklet Yaka Kısa Kollu Mickey Mouse Baskılı Penye Erkek Tişört", Price = 250, Stock = 1000, Description = "Pamuklu penye kumaştan" },
             new Product { Id = 4, CategoryId = 3, Name = "File Detaylı Kalın Taban Kadın Aktif Spor Ayakkabı", Price = 450, Stock = 10, Description = "Esnek rahat tabanlı" },
             new Product { Id = 4, CategoryId = 4, Name = "LCW CASUAL Standart Kalıp Kapüşonlu Şişme Mont", Price = 550, Stock = 19, Description = "Fermuar kapama" });

        }
    }
}
