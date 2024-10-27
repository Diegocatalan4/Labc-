using System;

class AcumuladorValores
{
    static void Main()
    {
        double suma = 0;
        int numero;

        Console.WriteLine("Ingrese números para acumular (ingrese 9999 para finalizar):");

        while (true)
        {
            Console.Write("Número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero == 9999)
                {
                    break;
                }
                suma += numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
        }

        Console.WriteLine($"Valor acumulado: {suma}");

        if (suma == 0)
        {
            Console.WriteLine("El valor acumulado es cero.");
        }
        else if (suma > 0)
        {
            Console.WriteLine("El valor acumulado es mayor a cero.");
        }
        else
        {
            Console.WriteLine("El valor acumulado es menor a cero.");
        }
    }
}
