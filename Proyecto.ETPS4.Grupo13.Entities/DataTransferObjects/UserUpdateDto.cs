using Proyecto.ETPS4.Grupo13.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects
{
    public class UserUpdateDto
    {
        [Required(ErrorMessage = "El primer nombre es requerido")]
        [Display(Name = "Nombres")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        [Display(Name = "Apellidos")]
        public string? LastName { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Escriba un correo electronico valido")]
        [Required(ErrorMessage = "Correo electronico es requerido")]
        [Display(Name = "Correo electrónico")]
        public string? Email { get; set; }
        [Display(Name = "Tipo de usuario")]
        public UserType UserType { get; set; } = UserType.Cashier;
        [Display(Name = "Habilitado")]
        public bool Enabled { get; set; } = false;
    }
}
