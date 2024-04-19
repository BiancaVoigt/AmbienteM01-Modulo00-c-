using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Conversao Implícita Int p/ Float

            *int a = 8;
            *float b = a;

            *Console.WriteLine( " O valor de a é " + a + " do tipo " + a.GetType());
            *Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());
            *Console.ReadKey();
            // Conversao Implícita float p/ Int dá erro pois um número float nao cabe dentro de um número inteiro
            */


            // Coversao Explícita
            /*
            
            *float a = 8.75f;
            *int b = (int)a;
            */

            // Conversao por Classes auxiliares

            float a = 8.75f;
            int b = Convert.ToInt32(a);

            Console.WriteLine( " O valor de a é " + a + " do tipo " + a.GetType());
            Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());
            Console.ReadKey();


}
}
}
