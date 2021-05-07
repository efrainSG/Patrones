using System;

namespace SernaSistemas.DesignPatterns.Bridge
{
    public class Abstraccion
    {
        protected IImplementacion _implementacion;
        public Abstraccion(IImplementacion implementacion)
        {
            _implementacion = implementacion;
        }

        public virtual string Operacion()
        {
            return $"Abstracto: Operación base con:\n{_implementacion.OperacionDeImplementacion()}";
        }
    }

    public class AbstraccionExtendida : Abstraccion
    {
        public AbstraccionExtendida(IImplementacion implementacion):base(implementacion)
        {

        }
        public override string Operacion()
        {
            return $"Abstracción exdendida: Operación extendida con:\n{base.Operacion()}";
        }
    }
}
