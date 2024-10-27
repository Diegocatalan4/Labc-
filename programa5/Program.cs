using System;

class UbicacionCuadrante
{
    static void Main()
    {
        Console.Write("Ingrese la coordenada x (distinta de cero): ");
        
        if (int.TryParse(Console.ReadLine(), out int x) && x != 0)
        {
            Console.Write("Ingrese la coordenada y (distinta de cero): ");
            
            if (int.TryParse(Console.ReadLine(), out int y) && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 1º Cuadrante.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 2º Cuadrante.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("El punto se encuentra en el 3º Cuadrante.");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("El punto se encuentra en el 4º Cuadrante.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. La coordenada y debe ser un número entero distinto de cero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. La coordenada x debe ser un número entero distinto de cero.");
        }
    }
}
