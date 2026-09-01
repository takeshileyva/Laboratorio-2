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
            double temperatura, ruido, indice;
            Console.WriteLine("Ingrese la temperatura interior (°C): ");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nivel del ruido: ");
            ruido = double.Parse(Console.ReadLine());
            indice = (temperatura * 0.5) + (ruido * 0.5);
            Console.WriteLine($"El índice es: {indice:F2}");
            if (indice < 30)
                Console.WriteLine("Es muy cómodo");
            else if (indice >= 30 && indice <= 50)
                Console.WriteLine("Es cómodo");
            else if (indice >= 51 && indice < 70)
                Console.WriteLine("Es poco cómodo");
            else
                Console.WriteLine("Es incómodo");
        }
    }
}
