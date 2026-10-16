using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1\\Desktop\\jhon\\productos.csv";


        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio");
            sw.WriteLine("1,Laptop asus,12000");
            sw.WriteLine("2,Mouse,30");
            sw.WriteLine("3,Monitor,400");
            sw.WriteLine("4,ram,2000");
            sw.WriteLine("5,disco SSD,14000");
            sw.WriteLine("6,procesador,22000");
            sw.WriteLine("7,Laptop HP,11000");
            sw.WriteLine("8,torre ,13000");
            sw.WriteLine("9,teclado,3000");
            sw.WriteLine("10,grafica,42000");
        }


        string[] lineas = File.ReadAllLines(ruta);


        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');


            double precio = double.Parse(campos[2]);

            if (precio > 100)
            {
                Console.WriteLine(
                    $"{campos[1]} - ${precio}"
                );
            }
        }
    }
}
