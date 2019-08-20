using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectofinal.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        public string nombreEmpresa { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int Nit { get; set; }

    }
}
