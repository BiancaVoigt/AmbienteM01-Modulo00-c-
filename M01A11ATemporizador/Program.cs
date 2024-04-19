using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A11ATemporizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.Write("Hoje é dia ");
            Thread.Sleep(1000);
            Console.Write(dia);
            Thread.Sleep(1000);
            Console.Write(" do mes ");
            Thread.Sleep(1000);
            Console.Write(mes);
            Thread.Sleep(1000);
            Console.WriteLine(" do ano de ");
            Thread.Sleep(1000);
            Console.WriteLine(ano);
            Thread.Sleep(3000);
        }
    }
}
