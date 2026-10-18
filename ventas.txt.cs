using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "ventas.txt";

        // Crear archivo de prueba ventas.txt
        File.WriteAllLines(ruta, new string[] {
            "Laptop:4",
            "Mouse:32",
            "Monitor:12",
            "Teclado:18"
        });

        string[] lineas = File.ReadAllLines(ruta);
        int totalVentas = 0;
        string productoMasVendido = "";
        int maxCantidad = -1;

        foreach (string linea in lineas)
        {
            string[] partes = linea.Split(':');
            if (partes.Length == 2)
            {
                string producto = partes[0].Trim();
                int cantidad = int.Parse(partes[1].Trim());

                // Acumular total de ventas
                totalVentas += cantidad;

                // Determinar el más vendido
                if (cantidad > maxCantidad)
                {
                    maxCantidad = cantidad;
                    productoMasVendido = producto;
                }
            }
        }

        Console.WriteLine($"Total general de unidades vendidas: {totalVentas}");
        Console.WriteLine($"Producto más vendido: {productoMasVendido} ({maxCantidad} unidades)");
    }
}
