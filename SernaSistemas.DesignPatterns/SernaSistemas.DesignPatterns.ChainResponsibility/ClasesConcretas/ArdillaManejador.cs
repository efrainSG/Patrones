namespace SernaSistemas.DesignPatterns.ChainResponsibility
{
    public class ArdillaManejador : ManejadorAbstracto
    {
        public override object Manejador(object request)
        {
            if ((request as string) == "nuez")
                return $"Ardilla: Comeré una {request.ToString()}.\n";
            else
                return base.Manejador(request);
        }
    }
}
