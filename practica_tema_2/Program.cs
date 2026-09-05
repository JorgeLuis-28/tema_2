using System;

namespace practica_tema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short num1, num2, suma, resta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ingrese numero 1: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            num1 = short.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ingrese numero 2: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            num2 = short.Parse(Console.ReadLine());
            suma = (short)(num1 + num2);
            resta = (short)(num1 - num2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("La suma es: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(suma);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("La resta es: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(resta);
            Console.ResetColor();
            
        }
    }
}
