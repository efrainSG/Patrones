namespace SernaSistemas.DesignPatterns.ChainResponsibility.Interfaces
{
    public interface IManejador
    {
        IManejador Siguiente(IManejador manejador);
        object Manejador(object request);
    }
}
