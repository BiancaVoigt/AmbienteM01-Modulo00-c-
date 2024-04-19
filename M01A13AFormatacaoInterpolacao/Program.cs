using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A13AFormatacaoInterpolacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Guatavo";
            float sal = 550.7556f;
            byte idade = 22;
            Console.WriteLine($"O {nome, -10} tem idade de {idade} anos e ganha {sal:c} por mes.");
            int num = 13;
            Console.WriteLine($"O número em Hexadecimal é {num:x}");
            Console.ReadKey();
        }
    }
}
