using System;
using System.Collections.Generic;
using System.Text;

namespace SernaSistemas.DesignPatterns.Factory.Interfaces
{
    public interface IFigura
    {
        double[] Lados { get; set; }
        double Perimetro();
        double Area();
    }
}
