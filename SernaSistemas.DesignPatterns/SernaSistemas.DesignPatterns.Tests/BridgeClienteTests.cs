using NUnit.Framework;
using SernaSistemas.DesignPatterns.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace SernaSistemas.DesignPatterns.Bridge.Tests
{
    [TestFixture()]
    public class BridgeClienteTests
    {
        [Test()]
        public void PrincipalTest()
        {
            BridgeCliente cliente = new BridgeCliente();
            cliente.Principal();
        }
    }
}