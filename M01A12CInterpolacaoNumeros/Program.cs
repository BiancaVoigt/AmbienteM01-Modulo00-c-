using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12CInterpolacaoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.Write("Qual é o seu salário? ");
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($" Voce ganha {sal:C} por mes !");
            Console.ReadKey();
        }
    }
}
