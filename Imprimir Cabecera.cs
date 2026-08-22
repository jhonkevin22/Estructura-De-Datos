using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void ImprimirCabecera(string nombreMateria, int Grupo, string nombredelestudiante, int edaddelestudiante, string correodelestudiante, string lugardondeviveelestudiante)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("          UNIVERSIDAD DEL CARIBE               ");
            Console.WriteLine($"ASIGNATURA : {nombreMateria}");
            Console.WriteLine($"  Grupo: {Grupo}");
            Console.WriteLine("===============================================");
            Console.WriteLine($" NOMBRE: {nombredelestudiante}");
            Console.WriteLine($"EDAD: {edaddelestudiante}");
            Console.WriteLine("===============================================");
            Console.WriteLine($"CORREO: { correodelestudiante}");
            Console.WriteLine($"LUGAR EN DONDE VIVE: {lugardondeviveelestudiante}");





        }
        static void Main(string[] args)
        {
            ImprimirCabecera("Fundamentos de programacion", 1, "Jhon Kevin Peña Gutierrez", 22, "jhonkevin22@gmail.com", "CIENAGA MAGDALENA");

        }

    }
}
