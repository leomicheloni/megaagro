using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.model
{
    public class Compra
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Factura Factura { get; set; }
        public string Fecha { get; set; }
        public string Importe { get; set; }
        public string Estado { get; set; }

        public class Detalle
        {
            public int Id { get; set; }
            public Repuesto Respuesto { get; set; }
            public int Cantidad { get; set; }
            public string Importe { get; set; }
        }
    }
}
