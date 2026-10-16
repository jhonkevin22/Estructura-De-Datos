using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1\\Desktop\\jhon\\estudiantes.csv";

        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');

                if (campos.Length >= 3)
                {
                    Console.WriteLine(
                        $"Nombre: {campos[0]}, Nota: {campos[2]}"
                    );
                }
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }

        using (StreamWriter sw = new StreamWriter(ruta, append: true))
        {
            sw.WriteLine("andres,21,3.8");
        }

        Console.WriteLine("Estudiante agregado exitosamente.");
    }
}
