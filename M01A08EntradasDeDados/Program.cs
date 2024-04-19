using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08EntradasDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie ist deine Name? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Hallo " + nome + "! alles gut?");
            Console.ReadKey();
        }
    }
}
