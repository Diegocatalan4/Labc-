using System;

class ContarParesImpares
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números que desea cargar: ");
        
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int contadorPares = 0;
            int contadorImpares = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (numero % 2 == 0)
                    {
                        contadorPares++;
                    }
                    else
                    {
                        contadorImpares++;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                    i--; // Para repetir el ingreso del número en caso de error
                }
            }

            Console.WriteLine($"Total de números pares: {contadorPares}");
            Console.WriteLine($"Total de números impares: {contadorImpares}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. La cantidad debe ser un número entero positivo.");
        }
    }
}
