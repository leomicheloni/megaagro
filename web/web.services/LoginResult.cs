using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.services
{
    public class LoginResult
    {
        public string Description { get; set; }
        public bool Success { get; set; }

        public static LoginResult WrongUser()
        {
            return new LoginResult { Success = false, Description = "Wrong user" }; // TODO: ver cuánta información se le da al usuario que intenta logearse
        }

        internal static LoginResult WrongPassword()
        {
            return new LoginResult { Success = false, Description = "Wrong user or password" };
        }

        internal static LoginResult Ok()
        {
            return new LoginResult { Success = true, Description = "" };
        }
    }
}
