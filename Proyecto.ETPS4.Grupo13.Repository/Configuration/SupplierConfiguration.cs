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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData(
                new Supplier
                {
                    Id = new Guid("c9cb77f5-13bc-4c99-92e4-0352ca84e72d"),
                    Name = "proveedor 1",
                    Address = "Santa Ana",
                    Email = "proveedor1@pos.com",
                    Phone = "12345"
                },
                new Supplier
                {
                    Id = new Guid("7bb9095c-9ff7-45ab-ae27-df868810b981"),
                    Name = "proveedor 2",
                    Address = "San Salvador",
                    Email = "proveedor2@pos.com",
                    Phone = "54321"
                }
            );
        }
    }
}
