using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
  public abstract class AnalisisAvanzado : IEstrategia
    {
        public void Analizar()
        {
            Iniciar();
            AnalizarMemoria();
            AnalizarKeyloggers();
            AnalizarRootkits();
            DescomprimirZips();
            Detener();
        }

        public abstract void Iniciar();
        public abstract void AnalizarMemoria();
        public abstract void AnalizarKeyloggers();
        public abstract void AnalizarRootkits();
        public abstract void DescomprimirZips();
        public abstract void Detener();

    }
}
