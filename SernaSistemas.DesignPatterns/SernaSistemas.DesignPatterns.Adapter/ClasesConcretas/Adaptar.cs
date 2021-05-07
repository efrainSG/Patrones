namespace SernaSistemas.DesignPatterns.Adapter.ClasesConcretas
{
    public class Adaptar
    {
        public string GetRequestEspecifico()
        {
            return "Request específico :: " + this.ToString();
        }
    }
}
