using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09Numeros_AleatoriosRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int n = gerador.Next(10);
            Console.WriteLine("Acabei de gerar o número " + n);
            Console.ReadKey();

        }
    }
}
