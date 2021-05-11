namespace SernaSistemas.DesignPatterns.ChainResponsibility
{
    public class MonoManejador : ManejadorAbstracto
    {
        public override object Manejador(object request)
        {
            if ((request as string) == "platano")
                return $"Mono: Comeré un {request.ToString()}.\n";
            else
                return base.Manejador(request);
        }
    }
}
