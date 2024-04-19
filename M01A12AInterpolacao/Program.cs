using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12AInterpolacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! tudo bem?");
            Console.ReadKey();

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine($"A data atual é {dia} de {mes} do ano de {ano}");
            Console.ReadKey();

        }
    }
}
