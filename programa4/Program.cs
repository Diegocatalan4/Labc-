using System;

class EvaluacionPorcentaje
{
    static void Main()
    {
        Console.Write("Ingrese el porcentaje de respuestas correctas: ");
        
        if (double.TryParse(Console.ReadLine(), out double porcentaje) && porcentaje >= 0 && porcentaje <= 100)
        {
            if (porcentaje >= 90)
            {
                Console.WriteLine("Nivel máximo");
            }
            else if (porcentaje >= 75)
            {
                Console.WriteLine("Nivel medio");
            }
            else if (porcentaje >= 50)
            {
                Console.WriteLine("Nivel regular");
            }
            else
            {
                Console.WriteLine("Fuera de nivel");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Ingrese un porcentaje entre 0 y 100.");
        }
    }
}
