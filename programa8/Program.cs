using System;

class MultiploDeOcho
{
    static void Main()
    {
        Console.WriteLine("Múltiplos de 8 hasta 500:");

        for (int i = 8; i <= 500; i += 8)
        {
            if (i < 500)
            {
                Console.Write(i + " - ");
            }
            else
            {
                Console.WriteLine(i); // Para imprimir el último número sin el guion
            }
        }
    }
}
