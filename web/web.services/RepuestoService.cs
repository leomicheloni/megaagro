using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using web.data;
using web.model;

namespace web.services
{
    public class RepuestoService
    {
        private IDataAccess dataAccess;

        public static RepuestoService Build()
        {
            return new RepuestoService(new MockedDataAccess());
        }

        public RepuestoService(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public IEnumerable<Repuesto> GetAll()
        {
            return this.dataAccess.Get<Repuesto>();
        }

    }
}
