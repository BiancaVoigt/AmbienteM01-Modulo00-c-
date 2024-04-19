using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08cLendoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite um número para saber o dobro dele: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int dobro = n * 2;
            Console.WriteLine("O dobro de " + n + " é igual a " + dobro + ".");
            Console.ReadKey();
            

            }
    }
}
