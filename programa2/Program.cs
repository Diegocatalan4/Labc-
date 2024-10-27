using System;

class CalculoPago
{
    static void Main()
    {
        Console.Write("Ingrese el precio del artículo: ");
        
        if (double.TryParse(Console.ReadLine(), out double precio))
        {
            Console.Write("Ingrese la cantidad que lleva el cliente: ");
            
            if (int.TryParse(Console.ReadLine(), out int cantidad))
            {
                double total = precio * cantidad;
                Console.WriteLine($"El total a abonar es: {total}");
            }
            else
            {
                Console.WriteLine("Entrada inválida para la cantidad. Por favor, ingrese un número entero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida para el precio. Por favor, ingrese un número válido.");
        }
    }
}
