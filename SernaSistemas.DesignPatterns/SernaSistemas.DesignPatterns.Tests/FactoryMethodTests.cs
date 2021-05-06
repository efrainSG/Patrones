using NUnit.Framework;

namespace SernaSistemas.DesignPatterns.Tests
{
    [TestFixture()]
    public class FactoryMethodTests
    {
        [Test()]
        public void PrincipalTest()
        {
            Cliente cliente = new Cliente();
            cliente.Principal();
        }
    }
}