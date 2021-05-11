using NUnit.Framework;
using SernaSistemas.DesignPatterns.ChainResponsibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace SernaSistemas.DesignPatterns.ChainResponsibility.Tests
{
    [TestFixture()]
    public class ChainClienteTests
    {
        [Test()]
        public void PrincipalTest()
        {
            ChainCliente.Principal();
        }
    }
}