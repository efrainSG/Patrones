using SernaSistemas.DesignPatterns.Adapter.ClasesConcretas;
using System;

namespace SernaSistemas.DesignPatterns.Adapter
{
    public class AdaptadorCliente
    {
        public void Principal()
        {
            Adaptar adaptar = new Adaptar();
            ITarget adaptador = new Adaptador(adaptar);
            Console.WriteLine(adaptar.GetRequestEspecifico());
            Console.WriteLine(adaptador.GetRequest());
        }
    }
}
