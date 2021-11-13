using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto context = new Contexto(new AntivirusSimple());
            context.Ejecutar();
            Console.WriteLine("-------------------------");
            Contexto context2 = new Contexto(new AntivirusAvanzado());
            context2.Ejecutar();
            Console.ReadKey();
        }
    }
}
