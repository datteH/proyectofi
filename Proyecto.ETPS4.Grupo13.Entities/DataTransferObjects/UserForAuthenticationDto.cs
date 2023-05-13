using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects
{
    public class UserForAuthenticationDto
    {
        [Display(Name = "Correo Electronico")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "User name is required")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Clave")]
        public string? Password { get; set; }
        [Display(Name = "Mantener sesión")]
        public bool RememberMe { get; set; }
    }
}
