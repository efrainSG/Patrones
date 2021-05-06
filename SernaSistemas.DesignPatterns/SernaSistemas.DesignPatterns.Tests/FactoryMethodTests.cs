using SernaSistemas.DesignPatterns.Factory;
using NUnit.Framework;

namespace SernaSistemas.DesignPatterns.Factory.Tests
{
    [TestFixture()]
    public class FactoryMethodTests
    {
        [Test()]
        public void AbstractFactoryPrincipalTest()
        {
            AbstractFactoryCliente cliente = new AbstractFactoryCliente();
            cliente.Principal();
        }

        [Test()]
        public void FactoryPrincipalTest()
        {
            FactoryCliente cliente = new FactoryCliente();
            cliente.Principal();
        }
    }
}