using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static double CalcularAreadeuncirculo(double radio)
        {
            const double PI = 3.141592;
            double area = PI * Math.Pow(radio, 2);
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el radio del circulo");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = CalcularAreadeuncirculo(r);
            Console.WriteLine($"el area es:{result:F2}");
        }
    }
}
