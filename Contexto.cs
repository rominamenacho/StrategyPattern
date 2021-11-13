using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Contexto
    {
        IEstrategia strategy;

       public Contexto(IEstrategia _strategy)
        {
            strategy = _strategy;
        }

        public void Ejecutar()
        {
            strategy.Analizar();
        }
    }
}
