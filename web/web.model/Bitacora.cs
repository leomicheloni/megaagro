using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.model
{
    public class Bitacora
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string  Fecha { get; set; }
        public string Tipo { get; set; }
        public string Criticidad { get; set; }
        public Usuario Usuario { get; set; }
    }
}
