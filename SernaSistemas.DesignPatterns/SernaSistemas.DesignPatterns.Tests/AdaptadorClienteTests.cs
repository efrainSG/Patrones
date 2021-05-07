using NUnit.Framework;

namespace SernaSistemas.DesignPatterns.Adapter.Tests
{
    [TestFixture()]
    public class AdaptadorClienteTests
    {
        [Test()]
        public void PrincipalTest()
        {
            AdaptadorCliente cliente = new AdaptadorCliente();
            cliente.Principal();
            Assert.Pass();
        }
    }
}