using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la longitud del lado del cuadrado: ");
        
        if (double.TryParse(Console.ReadLine(), out double lado))
        {
            double perimetro = lado * 4;
            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        }
    }
}