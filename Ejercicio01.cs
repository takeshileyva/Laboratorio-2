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
            double metros, cm;
            Console.WriteLine("Ingrese la cantidad en metros: ");
            metros = double.Parse(Console.ReadLine());
            cm = metros * 100;
            Console.WriteLine($"La cantidad en centímetros es: {cm}");
        }
    }
}
