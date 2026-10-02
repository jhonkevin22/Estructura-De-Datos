using System;

class Program
{
    static void Main()
    {
        const int estudiantes = 5;

        string[] nombres = new string[estudiantes];
        double[] notas = new double[estudiantes];

        for (int i = 0; i < estudiantes; i++)
        {
            Console.WriteLine("\nEstudiante " + (i + 1));

            
            for (bool valido = false; !valido;)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                if (nombres[i] != "")
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            }

           
            for (bool valido = false; !valido;)
            {
                Console.Write("Nota (0 a 5): ");
                string texto = Console.ReadLine();

                if (double.TryParse(texto, out notas[i]) &&
                    notas[i] >= 0 && notas[i] <= 5)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("La nota debe estar entre 0 y 5.");
                }
            }
        }

       
        double suma = 0;
        double mayor = notas[0];
        double menor = notas[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < estudiantes; i++)
        {
            suma = suma + notas[i];

            if (notas[i] > mayor)
            {
                mayor = notas[i];
            }

            if (notas[i] < menor)
            {
                menor = notas[i];
            }

            if (notas[i] >= 3)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = suma / estudiantes;

       
        Console.WriteLine("\n===== RESULTADOS =====");

        for (int i = 0; i < estudiantes; i++)
        {
            Console.WriteLine(
                nombres[i] + " - Nota: " + notas[i] +
                (notas[i] >= 3 ? " - Aprobado" : " - Reprobado")
            );
        }

        Console.WriteLine("\nPromedio: " + promedio);
        Console.WriteLine("Nota mayor: " + mayor);
        Console.WriteLine("Nota menor: " + menor);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }
}
