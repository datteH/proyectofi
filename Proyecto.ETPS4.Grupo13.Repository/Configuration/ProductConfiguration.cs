using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = new Guid("6a139d72-3254-4852-b432-795d8da23e45"),
                    Name = "Producto 1",
                    Description = "Descripcion producto 1",
                },
                new Product
                {
                    Id = new Guid("a9156c0e-4867-4af4-b7a5-3c85c28519b4"),
                    Name = "Producto 2",
                    Description = "Descripcion producto 2",
                },
                new Product
                {
                    Id = new Guid("a6285a0b-3b44-465c-9ab5-ac42f9d63032"),
                    Name = "Producto 3",
                    Description = "Descripcion producto 3",
                },
                new Product
                {
                    Id = new Guid("1ac417dc-6a0b-4b2a-a4de-b19da62ff1e7"),
                    Name = "Producto 4",
                    Description = "Descripcion producto 4",
                }
            );
        }
    }
}
