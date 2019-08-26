using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyectofinal.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        [Display(Name = "nombreEmpresa ")]
        [Required(ErrorMessage = "El campo nombreEmpresa es obligatorio")]
        [StringLength(13, ErrorMessage = "Longitud entre 5 y 13 caracteres.",
                     MinimumLength = 5)]
        [DataType(DataType.Text)]
        [RegularExpression("^[A-Za-z]*$")]
        public string nombreEmpresa { get; set; }
        [Display(Name = "direccion ")]
        [Required(ErrorMessage = "El campo direccion es obligatorio")]

        public string direccion { get; set; }

        [Display(Name = "telefono")]
        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*")]
        public string telefono { get; set; }

        [Display(Name = "correo")]
        [Required(ErrorMessage = "El campo correo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]

        public string correo { get; set; }
        [Display(Name = "Nit")]
        [Required(ErrorMessage = "El campo Nit es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*")]
        public int Nit { get; set; }

    }
}
