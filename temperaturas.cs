using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[5]; // Declaracion en inicializando

            Console.WriteLine("---- Ingreso de temperatura ----");
             
            //Lectura/escritura de nuestro vector
            for(int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine($"ingrese la temperatura del dia {i +  1}: ");
                temperaturas[i]= Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            double max =  temperaturas[0];
            double minT = temperaturas[0];


            foreach (double tem in temperaturas)
            {
                suma += tem;
                if (tem > max) max = tem;
                if (tem < minT) minT = tem;
               
            }

            double promedio = suma / temperaturas.Length;

            //salida de infortmacion
            Console.WriteLine("\n---reporte ---");
            Console.WriteLine($"temperaturas registradas: {string.Join(",",temperaturas)}");
            Console.WriteLine($"temperaturas promedio: {promedio:F2}°C");
            Console.WriteLine($"temperaturas maxima: {max}°C");
            Console.WriteLine($"temperaturas maxima: {minT}°C");






            Console.ReadKey();
        }
    }
}
