using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using web.model;

namespace web.data
{
    public class MockedDataAccess: IDataAccess
    {
        //public IQueryable<Factura> Get()
        //{
        //    return (new[]
        //    {
        //        new Factura { Id = 1, NroFactura = 1, Fecha = "2014-04-04", Usuario = 
        //            this.GetMockedUser(), Detalle = this.BuildDetails(2)}
        //    }).AsQueryable();
        //}

        private IEnumerable<Repuesto> BuildRepuestos(int cantidad)
        {
            var repuestos = new List<Repuesto>();

            for (var i = 0; i < cantidad; i++)
            {

                var repuesto = new Repuesto();
                repuesto.Activo = true;
                repuesto.Caracteristicas = "carateristica ";
                repuesto.Maquinaria = "maquinaria ";
                repuesto.PrecioCompra = "100";
                repuesto.PrecioVenta = "120";
                repuesto.Proveedor = new Proveedor
                    {
                        Activo = true,
                        Direccion = "calle 1 123",
                        FechaIngreso = "2010-01-23",
                        Nombre = "Proveedor 1",
                        Telefonos = new[] { "12232323", "3434343", "23423432" }
                    };
                repuesto.StockFisico = 30;

                repuestos.Add(repuesto);
            }

            return repuestos;
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

        private IEnumerable<Usuario> BuildUsuarios()
        {
            var usuarios = new List<Usuario>();

            for (var i = 0; i < 10; i++)
            {

                var usuario = new Usuario
                {
                    Activo = true,
                    Apellido = "perez",
                    Contrasena = "12345678",
                    Email = "juan" + i + "@perez.com",
                    Id = 1,
                    Nombre = "juan" + i,
                    NombreUsuario = "jperez" + i,
                    Telefonos = new List<string>()
                };

                usuarios.Add(usuario);
            }

            return usuarios;
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

            return null;
        }

        public IQueryable<Repuesto> Get()
        {
            return this.BuildRepuestos(10).AsQueryable<Repuesto>();
        }


        public IQueryable<Usuario> GetUsuarios()
        {
            return this.BuildUsuarios().AsQueryable();
        }
    }
}
