using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using web.model;

namespace web.data
{
    public interface IDataAccess
    {
        IQueryable<T> Get<T>();

        IQueryable<Usuario> GetUsuarios();
    }
}
