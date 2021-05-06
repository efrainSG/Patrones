using System;

namespace SernaSistemas.DesignPatterns
{
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
}