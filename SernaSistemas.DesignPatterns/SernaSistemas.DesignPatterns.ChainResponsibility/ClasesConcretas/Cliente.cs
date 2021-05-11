using System;
using System.Collections.Generic;

namespace SernaSistemas.DesignPatterns.ChainResponsibility
{
    public class Cliente
    {
        public static void ClientCode(ManejadorAbstracto manejador)
        {
            foreach (var item in new List<string> { "nuez", "platano", "tasa de café" })
            {
                Console.WriteLine($"Cliente: ¿Quién quiere... {item}?");
                var result = manejador.Manejador(item);
                if (result != null)
                    Console.WriteLine($"   {result}");
                else
                    Console.WriteLine($"   {item} se dejó sin tocar.");
            }
        }
    }
}
