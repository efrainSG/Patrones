using System;
using System.Collections.Generic;
using System.Text;

namespace SernaSistemas.DesignPatterns.Factory.Interfaces
{
    public interface IFabricaFiguras
    {
        IFigura CrearTriangulo();
        IFigura CrearCuadrilateroRegular();
        IFigura CrearTrapecio();
        IFigura CrearPoligonoRegular(int numLados, double longLados);
        IFigura CrearCirculo(double radio);
    }
}
