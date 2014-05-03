using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;
using web.data;

namespace web.services.tests
{
    [TestFixture]
    public class UserServiceFixture
    {
        private Mock<IDataAccess> mockedDataAccess = new Mock<IDataAccess>();

        [TestFixtureSetUp]
        public void Init()
        {
        }

        [Test]
        public void LoginUserOk()
        {
            mockedDataAccess.Setup(d => d.GetUsuarios());
            var target = new UsuarioService(new MockedDataAccess());
            var result = target.Login(new model.Usuario { Email = "juan0@perez.com", Contrasena = "12345678" });

            Assert.IsTrue(result.Success);
        }

        [Test]
        public void LoginUserWrongPassword()
        {
            mockedDataAccess.Setup(d => d.GetUsuarios());

            var target = new UsuarioService(new MockedDataAccess());
            var result = target.Login(new model.Usuario { Email = "juan0@perez.com", Contrasena = "12345___" });

            Assert.IsFalse(result.Success);
            Assert.AreEqual(LoginResult.WrongPassword(), result);
        }

    }
}
