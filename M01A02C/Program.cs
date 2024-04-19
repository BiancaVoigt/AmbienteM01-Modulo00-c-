using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02C
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine( "C# é \n\"SUPER\" \nFácil!\a");
            Console.ReadKey();
            Console.SetCursorPosition(10, 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Olá querida Bianca!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            
            Console.SetCursorPosition(20, 3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tudo bem com voce? Bom dia!");
            Console.ResetColor();



        }
    }
}
