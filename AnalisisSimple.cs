using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
  public abstract class AnalisisSimple : IEstrategia
    {
        public void Analizar()
        {
            Iniciar();
            SaltarZip();
            Detener();

        }

        public abstract void Iniciar();
        public abstract void SaltarZip();
        public abstract void Detener();

    }
}
