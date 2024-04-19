using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A10DataEHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine("A data atual é dia " + dia + " do mes " + mes + " do ano " + ano);
            
            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int seg = DateTime.Now.Second;
            Console.WriteLine(" A hora atual é " + hora + " horas " + min + " minutos e " + seg + " segundos ");
            Console.ReadKey();



        }
    }
}
