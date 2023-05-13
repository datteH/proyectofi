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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = new Guid("eaad98cf-606a-43ac-bb2f-be149d84b698"),
                    Name = "Cliente 1",
                    Email = "cliente1@pos.com",
                    Phone = "7890123",
                    DocumentNumber = "022456677"
                },
                new Customer
                {
                    Id = new Guid("ca10851c-786b-41ef-907a-a4f871027561"),
                    Name = "Cliente 2",
                    Email = "cliente2@pos.com",
                    Phone = "456987",
                    DocumentNumber = "770226497"
                }
            );
        }
    }
}
