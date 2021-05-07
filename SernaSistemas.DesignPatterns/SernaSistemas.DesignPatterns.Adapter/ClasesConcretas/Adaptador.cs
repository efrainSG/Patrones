namespace SernaSistemas.DesignPatterns.Adapter.ClasesConcretas
{
    public class Adaptador : ITarget
    {
        private readonly Adaptar adaptar;
        public Adaptador(Adaptar adaptar)
        {
            this.adaptar = adaptar;
        }
        public string GetRequest()
        {
            return $"Esto es '{adaptar.GetRequestEspecifico()}' desde {this.ToString()}";
        }

    }
}
