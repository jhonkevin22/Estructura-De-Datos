using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "datos.csv";
        // Creamos un archivo de prueba con delimitador ';'
        File.WriteAllText(ruta, "ID;Nombre;Edad;Activo\n1;Carlos;28;True\n2;Lucía;34;False");

        string[] lineas = File.ReadAllLines(ruta);
        if (lineas.Length == 0) return;

        // 1. Detectar el delimitador
        char delimitador = ',';
        if (lineas[0].Contains(';')) delimitador = ';';
        else if (lineas[0].Contains('\t')) delimitador = '\t';

        string[] cabecera = lineas[0].Split(delimitador);
        Console.WriteLine($"Delimitador detectado: '{delimitador}'");
        Console.WriteLine($"Total de campos: {cabecera.Length}\n");

        // 2. Analizar tipos de datos usando la primera fila de registros
        if (lineas.Length > 1)
        {
            string[] muestra = lineas[1].Split(delimitador);
            Console.WriteLine("--- Análisis de Tipos ---");
            for (int i = 0; i < cabecera.Length; i++)
            {
                string tipo = "Texto (string)";
                if (int.TryParse(muestra[i], out _)) tipo = "Entero (int)";
                else if (double.TryParse(muestra[i], out _)) tipo = "Decimal (double)";
                else if (bool.TryParse(muestra[i], out _)) tipo = "Booleano (bool)";

                Console.WriteLine($"Campo: {cabecera[i]} -> Tipo: {tipo}");
            }
        }
    }
}
