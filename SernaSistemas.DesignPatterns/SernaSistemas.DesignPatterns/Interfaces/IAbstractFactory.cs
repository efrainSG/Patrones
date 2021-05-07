using System;

namespace SernaSistemas.DesignPatterns
{
    public interface IAbstractFactory
    {
        IAbstractProductA CrearProductoA();
        IAbstractProductB CrearProductoB();
    }

    public interface IAbstractProductA
    {
        string FuncionUtilA();
    }

    public interface IAbstractProductB
    {
        string FuncionUtilB();
        string OtraFuncionUtilB(IAbstractProductA colaborador);
    }
}