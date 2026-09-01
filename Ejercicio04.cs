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
            double temperatura, indice;
            int horas;
            Console.WriteLine("Ingrese la temperatura ambiental (°C): ");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las horas de exposición al sol: ");
            horas = int.Parse(Console.ReadLine());
            indice = (temperatura * 0.6) + (horas * 0.4);
            Console.WriteLine($"El índice es: {indice:F2}");
            if (indice < 15)
                Console.WriteLine(" El índice es bajo");
            else if (indice >= 15 && indice <= 25)
                Console.WriteLine("El índice es moderado");
            else
                Console.WriteLine("El índice es alto");
        }
    }
}
