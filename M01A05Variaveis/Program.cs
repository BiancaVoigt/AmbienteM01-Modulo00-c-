using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace M01A05Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nome = " Bianca";

            Console.WriteLine( "A variavel nome tem " + nome);
            Console.WriteLine("nome é do tipo " +nome.GetType() );
            Console.ReadKey();

        }
    }
}
