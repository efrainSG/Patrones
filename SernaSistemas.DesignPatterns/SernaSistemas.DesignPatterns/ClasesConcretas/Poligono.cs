using SernaSistemas.DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SernaSistemas.DesignPatterns.Factory.ClasesConcretas
{
    public class Poligono : IFigura
    {
        public double[] Lados { get; set; }
        public double Apotema { get; set; }
        public Poligono(int numLados, double longLado)
        {
            Lados = new double[numLados];
            for (int i = 0; i < numLados; i++)
            {
                Lados[i] = longLado;
            }
        }

        public double Area() => Perimetro() * Apotema / 2d;
        public double Perimetro() => Lados.Sum();
    }
}
