using System;

namespace SernaSistemas.DesignPatterns
{
    public class FabricaConcreta1 : IAbstractFactory
    {
        public IAbstractProductA CrearProductoA()
        {
            return new ProductoConcretoA1();
        }

        public IAbstractProductB CrearProductoB()
        {
            return new ProductoConcretoB1();
        }
    }

    public class FabricaConcreta2 : IAbstractFactory
    {
        public IAbstractProductA CrearProductoA()
        {
            return new ProductoConcretoA2();
        }

        public IAbstractProductB CrearProductoB()
        {
            return new ProductoConcretoB2();
        }
    }

    public class ProductoConcretoA1 : IAbstractProductA
    {
        public string FuncionUtilA()
        {
            return "El resultado de la Función Útil A-1";
        }
    }

    public class ProductoConcretoA2 : IAbstractProductA
    {
        public string FuncionUtilA()
        {
            return "El resultado de la Función Útil A-2";
        }
    }

    public class ProductoConcretoB1 : IAbstractProductB
    {
        public string FuncionUtilB()
        {
            return "El resultado de la Función Útil B-1";
        }

        public string OtraFuncionUtilB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.FuncionUtilA();
            return $"El resultado de la colaboración con {resultado}";
        }
    }
    public class ProductoConcretoB2 : IAbstractProductB
    {
        public string FuncionUtilB()
        {
            return "El resultado de la Función Útil B-2";
        }

        public string OtraFuncionUtilB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.FuncionUtilA();
            return $"El resultado de la colaboración con {resultado}";
        }
    }
}