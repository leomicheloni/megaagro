using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public bool Activo { get; set; }
        public IEnumerable<string> Telefonos { get; set; }
    }
}
