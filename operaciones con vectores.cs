using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int[] codigos = new int[20];
           for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine($"ingrese el codigo {i + 1}: ");
                codigos[i] = (int)Convert.ToDouble(Console.ReadLine());
           
           

           }
            Console.WriteLine("ingrese el codigo que desea buscar : ");
            int busqueda = Convert.ToInt32( Console.ReadLine());
            int indiceEcondrado = -1;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEcondrado = i;
                    break;
                }

            }

            if (indiceEcondrado != -1)
            {
                Console.WriteLine("ingrese el nuevo codigo: ");
                codigos[indiceEcondrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nVector Actualizado: {string.Join(", ", codigos)}");
            }
            else
            {
                Console.WriteLine("\n Error: El codigo ingresado mo existe en la BDD.");
            }
            Console.WriteLine("valor indice: {indiceEncontrado}");
        }
    }
}
