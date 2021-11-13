using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class AntivirusAvanzado : AnalisisAvanzado
    {
        public override void AnalizarKeyloggers()
        {
            Console.WriteLine("Analizando Keyloggers");
            Thread.Sleep(2000);
        }

        public override void AnalizarMemoria()
        {
            Console.WriteLine("Analizando Memoria");
            Thread.Sleep(2000);

        }

        public override void AnalizarRootkits()
        {
            Console.WriteLine("Analizando Rootkits");
            Thread.Sleep(2000);
        }

        public override void DescomprimirZips()
        {
            Console.WriteLine("Analizando zips");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el Analisis");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando el Analisis Avanzado");
        }
    }
}
