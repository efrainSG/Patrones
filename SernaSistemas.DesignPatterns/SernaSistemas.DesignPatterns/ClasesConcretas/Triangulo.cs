using SernaSistemas.DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SernaSistemas.DesignPatterns.Factory.ClasesConcretas
{
    public class Triangulo : IFigura
    {
        public double Altura { get; set; }
        public double[] Lados { get; set; }

        public Triangulo()
        {
            Lados = new double[3];
        }
        public double Area() => Lados[0] * Altura / 2d;
        public double Perimetro() => Lados.Sum();
    }
}
