using System;

namespace SernaSistemas.DesignPatterns.Bridge
{
    public class ImplementacionConcretaA : IImplementacion
    {
        public string OperacionDeImplementacion()
        {
            return "Implementación Concreta A: El resulta en plataforma A.\n";
        }
    }

    public class ImplementacionConcretaB : IImplementacion
    {
        public string OperacionDeImplementacion()
        {
            return "Implementación Concreta B: El resulta en plataforma B.\n";
        }
    }
}
