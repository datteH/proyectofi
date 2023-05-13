using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.ETPS4.Grupo13.Entities.Enums;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            var users = new List<User>();
            var cashier = new User
            {
                Id = "e275eee8-4036-4274-bc77-6e190643ba52",
                FirstName = "Cajero 1",
                LastName = "Cajero 1",
                UserName = "cajero1",
                Email = "cajero1@pos.com",
                NormalizedEmail = "cajero1@pos.com",
                Enabled = true,
                UserType = UserType.Cashier,
            };
            cashier.PasswordHash = hasher.HashPassword(cashier, "cajero123#");

            var admin = new User
            {
                Id = "38d43087-3161-487f-a5c2-d8f242d3036a",
                FirstName = "Admin 1",
                LastName = "Admin 1",
                UserName = "admin1",
                Email = "admin1@pos.com",
                NormalizedEmail = "admin1@pos.com",
                Enabled = true,
                UserType = UserType.Administrator,
            };
            admin.PasswordHash = hasher.HashPassword(admin, "admin123#");

            users.Add(cashier); users.Add(admin);

            builder.HasData(users);
        }
    }
}
