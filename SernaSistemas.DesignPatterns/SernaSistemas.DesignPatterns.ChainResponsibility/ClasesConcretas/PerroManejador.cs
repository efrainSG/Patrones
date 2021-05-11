namespace SernaSistemas.DesignPatterns.ChainResponsibility
{
    public class PerroManejador : ManejadorAbstracto
    {
        public override object Manejador(object request)
        {
            if ((request as string) == "bola de carne")
                return $"Perro: Comeré una {request.ToString()}.\n";
            else
                return base.Manejador(request);
        }
    }
}
