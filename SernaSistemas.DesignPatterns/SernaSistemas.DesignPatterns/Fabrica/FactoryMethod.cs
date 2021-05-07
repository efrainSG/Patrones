using System;

namespace SernaSistemas.DesignPatterns
{
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
}