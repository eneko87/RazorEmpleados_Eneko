using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorEmpleados_Eneko.Models
{
    public class Empleados
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido(s)")]
        public string Apellido { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Teléfono")]
        public int Telefono { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }

    }
}
