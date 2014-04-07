using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using web.model;
using web.data;

namespace web.services
{
    public class FacturaService
    {
        private IDataAccess dataAccess;

        public static FacturaService Build()
        {
            return new FacturaService(new MockedDataAccess());
        }

        public FacturaService(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public IEnumerable<Factura> GetAll()
        {
            return this.dataAccess.Get<Factura>();
        }
    }
}
