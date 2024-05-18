using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Pacagroup.Ecommerce.Application.Interface;

namespace Pacagroup.Ecommerce.Application.Test
{
    [TestClass]
    public class UsersApplicationTest
    {
        private static WebApplicationFactory<Program> _factory = null;
        private static IServiceScopeFactory _scopeFactory = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext _)
        {
            _factory = new CustomWebApplicationFactory();
            _scopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();
        }

        [TestMethod]
        public void Authenticate_CuandoNoSeEnvianParametros_RetornarMensajeParametrosNoPuedenSerVacios()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IUsersApplication>();

            // Arrange: Donde se inicializan los objetos necesarios para la ejecución del código.
            var userName = string.Empty;
            var password = string.Empty;
            var expected = "Parametros no pueden ser vacios.";

            // Act: Donde se ejecuta el método que se va a probar y se obtiene el resultado.
            var result = context.Authenticate(userName, password);
            var actual = result.Message;

            // Assert: Donde se comprueba que el resultado obtenido es el esperado.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Authenticate_CuandoSeEnvianParametrosCorrectos_RetornarMensajeAutentificacionExitosa()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IUsersApplication>();

            // Arrange: Donde se inicializan los objetos necesarios para la ejecución del código.
            var userName = "ALEX";
            var password = "123456";
            var expected = "¡Autentificacion Exitosa!";

            // Act: Donde se ejecuta el método que se va a probar y se obtiene el resultado.
            var result = context.Authenticate(userName, password);
            var actual = result.Message;

            // Assert: Donde se comprueba que el resultado obtenido es el esperado.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Authenticate_CuandoSeEnvianParametrosIncorrector_RetornarMensajeUsuarioNoExiste()
        {
            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<IUsersApplication>();

            // Arrange: Donde se inicializan los objetos necesarios para la ejecución del código.
            var userName = "ALEXA";
            var password = "123456";
            var expected = "Usuario no existe.";

            // Act: Donde se ejecuta el método que se va a probar y se obtiene el resultado.
            var result = context.Authenticate(userName, password);
            var actual = result.Message;

            // Assert: Donde se comprueba que el resultado obtenido es el esperado.
            Assert.AreEqual(expected, actual);
        }
    }
}