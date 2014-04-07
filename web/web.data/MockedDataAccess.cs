using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using web.model;

namespace web.data
{
    public class MockedDataAccess: IDataAccess
    {
        public IQueryable<Factura> Get()
        {
            return (new[]
            {
                new Factura { Id = 1, NroFactura = 1, Fecha = "2014-04-04", Usuario = 
                    this.GetMockedUser(), Detalle = this.BuildDetails(2)}
            }).AsQueryable();
        }

        private IEnumerable<Compra.Detalle> BuildDetails(int cantidad)
        {
            for (var i = 0; i < cantidad; i++)
            {
                yield return new Compra.Detalle
                {
                    Id = i,
                    Cantidad = 2 * i,
                    Importe = (2 * 1 * 50).ToString(),
                    Respuesto = this.GetRespuesto()
                };
            }
        }

        private Usuario GetMockedUser()
        {
            return new Usuario();
        }

        private Repuesto GetRespuesto()
        {
            return new Repuesto();
        }

        public IQueryable<T> Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}
