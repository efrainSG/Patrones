using SernaSistemas.DesignPatterns.Bridge;
using System;

namespace SernaSistemas.DesignPatterns.Bridge
{
    public class BridgeCliente
    {
        public void ClientCode(Abstraccion abstraccion)
        {
            Console.WriteLine(abstraccion.Operacion());
        }

        public void Principal()
        {
            Abstraccion abstraccion = new Abstraccion(new ImplementacionConcretaA());
            ClientCode(abstraccion);

            Console.WriteLine();

            abstraccion = new Abstraccion(new ImplementacionConcretaB());
            ClientCode(abstraccion);

        }
    }
}
