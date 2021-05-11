using System;

namespace SernaSistemas.DesignPatterns.ChainResponsibility
{
    public class ChainCliente
    {
        public static void Principal()
        {
            var mono = new MonoManejador();
            var ardilla = new ArdillaManejador();
            var perro = new PerroManejador();

            mono.Siguiente(ardilla).Siguiente(perro);

            Console.WriteLine("Cadena: mono > ardilla > perro\n");
            Cliente.ClientCode(mono);
            Console.WriteLine("\nSubcadena: ardilla > perro\n");
            Cliente.ClientCode(ardilla);
        }
    }
}
