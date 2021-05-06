using System;

namespace SernaSistemas.DesignPatterns.Factory
{
    public class AbstractFactoryCliente
    {
        public void MetodoCliente(IAbstractFactory fabrica)
        {
            var ProductoA = fabrica.CrearProductoA();
            var ProductoB = fabrica.CrearProductoB();

            Console.WriteLine(ProductoB.FuncionUtilB());
            Console.WriteLine(ProductoB.OtraFuncionUtilB(ProductoA));
        }
        public void Principal()
        {
            Console.WriteLine("Probando cliente con la primera fábrica.");
            MetodoCliente(new FabricaConcreta1());
            Console.WriteLine("Probando cliente con la segunda fábrica.");
            MetodoCliente(new FabricaConcreta2());
        }
    }
}
