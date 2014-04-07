using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.Models
{
    /// <summary>
    /// Representa un usuario desde el punto de vista de la vista
    /// en el momento del login
    /// </summary>
    public class LoginUserViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
