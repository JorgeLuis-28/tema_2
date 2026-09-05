using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prueba_Tema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la Nota 1(T1): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int N1 = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Ingrese la Nota 2(T2): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int N2 = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Ingrese la Nota 3(T3): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int N3 = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Ingrese la Nota 4(EP): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int N4 = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Ingrese la Nota 5(EF): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int N5 = int.Parse(Console.ReadLine());
            Console.ResetColor();
            float Promedio;
            Promedio = (float)((N1 * 0.10) + (N2 * 0.10) + (N3 * 0.10) + (N4 * 0.20) + (N5 * 0.50));
            Console.Write("La nota final es: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Promedio);
            Console.ResetColor();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();   
                Console.WriteLine("Calculando estado. ");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Calculando estado.. ");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Calculando estado... ");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Calculando estado.... ");
                Thread.Sleep(100);
                Console.Clear();
            }
            Console.WriteLine("Calculando estado.... ");
            if (Promedio>12.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aprobado " + Promedio);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Desaprobado " + Promedio);
            }
            Console.ResetColor();
        }
    }
}
