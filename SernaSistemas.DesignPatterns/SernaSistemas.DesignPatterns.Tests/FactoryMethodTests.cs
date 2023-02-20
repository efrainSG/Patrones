using SernaSistemas.DesignPatterns.Factory;
using NUnit.Framework;
using SernaSistemas.DesignPatterns.Factory.Interfaces;
using SernaSistemas.DesignPatterns.Factory.ClasesConcretas;
using System;
using SernaSistemas.DesignPatterns.Factory.Fabrica;

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
            Assert.True(true);
        }

        [Test()]
        public void FactoryPrincipalTest()
        {
            FactoryCliente cliente = new FactoryCliente();
            cliente.Principal();
            Assert.True(true);
        }

        [Test()]
        public void FabricaFigurasTriangulo()
        {
            FabricaFiguras fabricaFiguras = new FabricaFiguras();
            IFigura figura = fabricaFiguras.CrearTriangulo();
            figura.Lados[0] = 8d;
            figura.Lados[1] = 10d;
            figura.Lados[2] = 10d;
            (figura as Triangulo).Altura = 3d;
            Assert.AreEqual(28d, figura.Perimetro());
            Assert.AreEqual(12d, figura.Area());
        }

        [Test()]
        public void FabricaFigurasCirculo()
        {
            FabricaFiguras fabricaFiguras = new FabricaFiguras();
            IFigura figura = fabricaFiguras.CrearCirculo(10);
            Assert.AreEqual(Math.PI * 100d, figura.Area());
            Assert.AreEqual(Math.PI * 20d, figura.Perimetro());
        }
    }
}