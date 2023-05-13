using Microsoft.AspNetCore.Identity;
using Proyecto.ETPS4.Grupo13.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Entities.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public UserType UserType { get; set; } = UserType.Cashier;
        public bool Enabled { get; set; }
    }
}
