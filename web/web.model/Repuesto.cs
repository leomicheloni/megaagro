using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.model
{
    public class Repuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Caracteristicas { get; set; }
        public string Maquinaria { get; set; }
        public Proveedor Proveedor { get; set; }
        public int StockFisico { get; set; }
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public bool Activo { get; set; }

    }
}
