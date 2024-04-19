using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A06Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constantes nao mudam , como o próprio nome já sugere. Se a minha Variável nao varia, ela é uma Constante. (adicione o const na frente)

           const string escola = "Estudonauta";
            float PI = 3.1415f;

            //escola = "CursoEmVideo"; Comando dá ERRO, pois eu pus a constante para que escola seja "Estudonauta e nao mude"

            Console.WriteLine("Eu estudo no " + escola); // o sinal de + é um sinal de concatenacao, eu estou juntando uma coisa na outra.

            Console.ReadKey();
            Console.WriteLine("O tipo de PI em Math é " + Math.PI.GetType()); // No Math é o valor real de Pi
            Console.WriteLine("O tipo de Pi no meu programa é " + PI.GetType()); // aqui é no meu Pi, q eu pus na variável acima.
            Console.ReadKey();
        }
    }
}
