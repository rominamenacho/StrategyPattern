using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class AntivirusSimple : AnalisisSimple
    {
        public override void Detener()
        {
            Console.WriteLine("Deteniendo el Analisis");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando el Analisis");
            Thread.Sleep(2000);
        }

        public override void SaltarZip()
        {
            Console.WriteLine("Los zips no se analizaran");
        }
    }
}
