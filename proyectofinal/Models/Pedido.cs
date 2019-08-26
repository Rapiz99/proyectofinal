using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyectofinal.Models
{
    public class Pedido
    {
        internal static object proveedorID;

        [Display(Name = "Pedido")]
        public int PedidoID { get; set; }
        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "El campo Proveedor es requerido.")]
        public int ProveedorID { get; set; }
        public Proveedor Proveedor { get; set; }
        [Required(ErrorMessage = "El campo fecha es requerido.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime FechaPedido { get; set; }
    }
}
