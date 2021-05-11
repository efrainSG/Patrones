using SernaSistemas.DesignPatterns.ChainResponsibility.Interfaces;

namespace SernaSistemas.DesignPatterns.ChainResponsibility
{
    public abstract class ManejadorAbstracto : IManejador
    {
        private IManejador _SiguienteManejador;
        public virtual object Manejador(object request)
        {
            if (this._SiguienteManejador != null)
                return this._SiguienteManejador.Manejador(request);
            else
                return null;
        }

        public IManejador Siguiente(IManejador manejador)
        {
            this._SiguienteManejador = manejador;
            return manejador;
        }
    }
}
