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
            double temperatura, humedad, indice;
            Console.WriteLine("Ingrese la temperatura (°C): ");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la humedad (%): ");
            humedad = double.Parse(Console.ReadLine());
            indice = (temperatura * 0.7) + (ruido * 0.3);
            Console.WriteLine($"El índice es: {indice:F2}");
            if (indice < 20)
                Console.WriteLine("Es Frío");
            else if (indice >= 20 && indice <= 30)
                Console.WriteLine("Es confortable");
            else 
                Console.WriteLine("Es caluroso/húmedo");
        }
    }
}
