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
            int pacientes;
            Console.WriteLine("Ingrese la cantidad de pacientes: ");
            pacientes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= pacientes; i++)
            {
                int fc, pas, pad;
                double temperatura, pam, ic;
                Console.WriteLine("Ingrese su frecuencia cardíaca en latidos por minuto: ");
                fc = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su presión arterial sistólica en mmHg: ");
                pas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su presión arterial diastólica en mmHg: ");
                pad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su temperatura corporal (°C): ");
                temperatura = double.Parse(Console.ReadLine());
                pam = pad + (pas - pad) / 3.0;
                ic = (double)fc / pas;
                Console.WriteLine("Su frecuencia cardíaca es: " + fc);
                Console.WriteLine("Su presión arterial sistólica es: " + pas);
                Console.WriteLine("Su presión arterial diastólica es: " + pad);
                Console.WriteLine($"Su temperatura corporal es: {temperatura:F1}");
                Console.WriteLine($"Su presión arterial media es: {pam:F1}");
                Console.WriteLine($"Su índice de choque es: {ic:F2}");
                if (ic >= 0.5 && ic <= 0.7)
                    Console.WriteLine("El índice de choque está normal");
                else if (ic > 0.7 && ic <= 0.9)
                    Console.WriteLine("El índice de choque está ligeramente elevado (vigilar)");
                else if (ic > 0.9 && ic < 1.0)
                    Console.WriteLine("El índice de choque está en posible estado de choque (riesgo)");
                else if (ic >= 1.0)
                    Console.WriteLine("El índice de choque está en alto riesgo, posible shock grave");
                else
                    Console.WriteLine("ERROR");
            }
    }
}
