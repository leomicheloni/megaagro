using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using web.model;
using web.data;

namespace web.services
{
    public class UsuarioService
    {
        private IDataAccess dataAccess;

        public UsuarioService (IDataAccess dataAccess)
	    {
            this.dataAccess = dataAccess;
	    }

        public LoginResult Login(Usuario usuario)
        {
            if (this.dataAccess.GetUsuarios().Any(u => u.Email == usuario.Email))
            {
                var existingUser = this.dataAccess.GetUsuarios().First(u => u.Email == usuario.Email);

                if (existingUser.Contrasena != usuario.Contrasena) // TODO: encriptar
                {
                    return LoginResult.WrongPassword();
                }
                // TODO: usuario bloqueado o inactivo?
                return LoginResult.Ok();
            }
            else
            {
                return LoginResult.WrongUser();
            }
            
        }

        public static UsuarioService Build()
        {
            return new UsuarioService(new MockedDataAccess());
        }
    }
}
