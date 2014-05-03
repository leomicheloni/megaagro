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

        public static LoginResult WrongPassword()
        {
            return new LoginResult { Success = false, Description = "Wrong user or password" };
        }

        public static LoginResult Ok()
        {
            return new LoginResult { Success = true, Description = "" };
        }

        public override bool Equals(object obj)
        {
            var other = (LoginResult)obj;
            return other.Description.Equals(this.Description) && other.Success == this.Success;
        }

        public override int GetHashCode()
        {
            return this.Success.GetHashCode() ^ this.Description.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("sucess: {0} => {1}", this.Success, this.Description);
        }
    }
}
