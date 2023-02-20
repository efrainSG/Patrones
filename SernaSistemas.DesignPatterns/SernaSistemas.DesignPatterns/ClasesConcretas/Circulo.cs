using SernaSistemas.DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SernaSistemas.DesignPatterns.Factory.ClasesConcretas
{
    public class Circulo : IFigura
    {
        public double Radio { get; set; }
        public double[] Lados { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double Area() => Math.PI * Radio * Radio;

        public double Perimetro() => Math.PI * Radio * 2;
    }
}
