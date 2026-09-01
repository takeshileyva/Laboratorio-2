using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, total_segundos;
            Console.WriteLine("Ingrese la hora: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos: ");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos: ");
            segundos = int.Parse(Console.ReadLine());
            total_segundos = (horas * 3600) + (minutos * 60) + segundos;
            Console.WriteLine($"El total de segundos es: {total_segundos}");
        }
    }
}
