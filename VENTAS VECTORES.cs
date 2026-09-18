using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] ventas   = {100.00, 200.00, 300.00, 2324.32, 4324.32, 234.234, 234.234,344124.1224,123.12312 };
            double total = 0;
            double mayorVenta = ventas[0];
            double menorVenta = ventas[0];
            int diaMayorVenta = 0;
            int diaMenorVenta = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i];
                if (ventas[i] > mayorVenta)
                {
                    mayorVenta = ventas[i];
                    diaMayorVenta = i;
                }
                if (ventas[i] > menorVenta)
                    menorVenta = ventas[i];
                    diaMenorVenta = i;
            }

            double promedio = total / ventas.Length;
            int diasSobrepromedio = 0;

            for(int i = 0;i < ventas.Length;i++)
                 if(ventas[i] > promedio)
                {
                    diasSobrepromedio++;
                }
            Console.WriteLine("============ reporte de ventas =============");
            Console.WriteLine();
            Console.WriteLine($"total vendido: ${total:F2}");
            Console.WriteLine($"promedio diario: ${promedio:F2}");
            Console.WriteLine();

            Console.WriteLine($"Mayor venta ${mayorVenta:F2} - el dia {diaMayorVenta + 1} ");
            Console.WriteLine($"Menor venta ${menorVenta:F2} - el dia {diaMenorVenta + 1} ");

            Console.WriteLine($"dias que superaron el promedio de ventas: {diasSobrepromedio} ");
            Console.WriteLine();

            Console.WriteLine("ventas por dias ");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"dia {i +1 } {ventas[i]:F2}");
            }















            Console.ReadKey();
        }
    }
}
