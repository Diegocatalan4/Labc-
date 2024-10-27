using System;

class CantidadDigitos
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo de hasta tres dígitos: ");
        
        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
        {
            if (numero < 10)
            {
                Console.WriteLine("El número tiene 1 dígito.");
            }
            else if (numero < 100)
            {
                Console.WriteLine("El número tiene 2 dígitos.");
            }
            else if (numero < 1000)
            {
                Console.WriteLine("El número tiene 3 dígitos.");
            }
            else
            {
                Console.WriteLine("Error: El número tiene más de 3 dígitos.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Ingrese un número entero positivo de hasta tres dígitos.");
        }
    }
}
