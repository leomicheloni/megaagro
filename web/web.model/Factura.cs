using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.model
{
    public class Factura
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Fecha { get; set; }
        public int NroFactura { get; set; }
        public IEnumerable<Compra.Detalle> Detalle { get; set; }
    }
}
