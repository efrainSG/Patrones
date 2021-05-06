using System;
using System.Collections.Generic;
using System.Text;

namespace SernaSistemas.DesignPatterns.Adapter.ClasesConcretas
{
    public class Adaptador : ITarget
    {
        private readonly Adaptar adaptar;
        public Adaptador(Adaptar adaptar)
        {
            this.adaptar = adaptar;
        }
        public string GetRequest() => $"Esto es '{adaptar.GetRequestEspecifico()}'.";
        
    }
}
