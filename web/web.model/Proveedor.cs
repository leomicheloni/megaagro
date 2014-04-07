using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.model
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaEgreso { get; set; }
        public IEnumerable<string> Telefonos { get; set; }
    }
}
