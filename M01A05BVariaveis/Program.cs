using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05BVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte idade = 25;
            ushort publico = 25_239;
            float media = 4.5f;  // para usar o float tem por"F" no final se nao dá erro, poede ser f minúsculo ou maiúsculo.
            decimal estrela = 4.524896335m; // Para usar decimal tem que por "M" no final.
            bool aprovado = false;

        

            Console.WriteLine(estrela);
            Console.ReadKey();



        }
    }
}
