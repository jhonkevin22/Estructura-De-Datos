using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "inventario.csv";


        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Cantidad,Precio");
            sw.WriteLine("1,Teclado Mecánico,15,45.00");
            sw.WriteLine("2,Mouse Inalámbrico,5,20.50");
            sw.WriteLine("3,Monitor 24\",8,180.00");
            sw.WriteLine("4,Cable USB-C,25,8.50");
        }

     
        Console.WriteLine("--- Alerta: Stock menor a 10 unidades ---");
        string[] lineas = File.ReadAllLines(ruta);
        
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            int cantidad = int.Parse(campos[2]);

            if (cantidad < 10)
            {
                Console.WriteLine($"Producto: {campos[1]} | Stock actual: {cantidad}");
            }
        }
    }
}
