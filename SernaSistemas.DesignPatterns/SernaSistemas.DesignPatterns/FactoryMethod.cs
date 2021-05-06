using System;

namespace SernaSistemas.DesignPatterns
{
    public interface IProducto
    {
        string Operacion();
    }

    public class FactoryMethod
    {
        public FactoryMethod()
        {

        }
    }

    public abstract class Creador
    {
        public abstract IProducto MetodoFabrica();
        public string AlgunaOperacion()
        {
            var Producto = MetodoFabrica();
            var resultado = "Creador: el mismo código que ha trabajado con " + Producto.Operacion();
            return resultado;
        }
    }

    public class CreadorConcreto1 : Creador
    {
        public override IProducto MetodoFabrica()
        {
            return new ProductoConcreto1();
        }
    }

    public class CreadorConcreto2 : Creador
    {
        public override IProducto MetodoFabrica()
        {
            return new ProductoConcreto2();
        }
    }

    public class ProductoConcreto1 : IProducto
    {
        public string Operacion()
        {
            return "Resultado de ProductoConcreto1.";
        }
    }

    public class ProductoConcreto2 : IProducto
    {
        public string Operacion()
        {
            return "Resultado de ProductoConcreto2.";
        }
    }

    public class Cliente
    {
        public void ClientCode(Creador creador)
        {
            Console.WriteLine("Cliente: No importa la clase creadora pero funciona.\n" + creador.AlgunaOperacion());
        }
        public void Principal()
        {
            Console.WriteLine("App: lanzado desde Creador concreto 1");
            ClientCode(new CreadorConcreto1());
            Console.WriteLine("\n");
            Console.WriteLine("App: lanzado desde Creador concreto 2");
            ClientCode(new CreadorConcreto2());

        }
    }
}