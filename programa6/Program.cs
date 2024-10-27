using System;

class AumentoSueldo
{
    static void Main()
    {
        Console.Write("Ingrese el sueldo del operario: ");
        
        if (double.TryParse(Console.ReadLine(), out double sueldo) && sueldo >= 0)
        {
            Console.Write("Ingrese los años de antigüedad del operario: ");
            
            if (int.TryParse(Console.ReadLine(), out int antiguedad) && antiguedad >= 0)
            {
                if (sueldo <= 500)
                {
                    if (antiguedad >= 10)
                    {
                        sueldo *= 1.20; // Aumento del 20%
                    }
                    else
                    {
                        sueldo *= 1.05; // Aumento del 5%
                    }
                }

                Console.WriteLine($"El sueldo a pagar es: {sueldo}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. La antigüedad debe ser un número entero positivo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. El sueldo debe ser un número positivo.");
        }
    }
}
