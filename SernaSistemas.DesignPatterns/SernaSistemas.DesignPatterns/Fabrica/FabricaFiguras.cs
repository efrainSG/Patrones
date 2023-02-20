using SernaSistemas.DesignPatterns.Factory.ClasesConcretas;
using SernaSistemas.DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SernaSistemas.DesignPatterns.Factory.Fabrica
{
    public class FabricaFiguras : IFabricaFiguras
    {
        public IFigura CrearCirculo(double radio) => new Circulo(radio);

        public IFigura CrearCuadrilateroRegular()
        {
            throw new NotImplementedException();
        }

        public IFigura CrearPoligonoRegular(int numLados, double longLados) => new Poligono(numLados, longLados);

        public IFigura CrearTrapecio()
        {
            throw new NotImplementedException();
        }

        public IFigura CrearTriangulo() => new Triangulo();
    }
}
