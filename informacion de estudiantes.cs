using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "Informacion de estudiantes.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Edad,Nota");
            sw.WriteLine("jhon,22,5");
            sw.WriteLine("juan,32,5");
            sw.WriteLine("maria,23,3.8");
        }

        Console.WriteLine("Archivo creado exitosamente.");
    }
}
