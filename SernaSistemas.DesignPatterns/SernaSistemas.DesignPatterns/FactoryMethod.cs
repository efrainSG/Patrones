using System;

namespace SernaSistemas.DesignPatterns
{
    public class FactoryCliente
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