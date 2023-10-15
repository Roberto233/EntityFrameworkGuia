using Guia_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        using (var context = new Context())
        {
            context.Database.EnsureCreated();

            bool Continuar = true;

            while (Continuar)
            {
                Student estudiante = new Student();

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Ingrese el Nombre: ");
                estudiante.Nombre = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Ingrese el Apellido: ");
                estudiante.Apellido = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Ingrese el Sexo: ");
                estudiante.Sexo = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Ingrese el Edad: ");
                estudiante.Edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                context.Add(estudiante);
                context.SaveChanges();

                Console.WriteLine("----------------------------------------------");

                Console.WriteLine("");

                Console.WriteLine("Estudiante agregado correctamente.");

                Console.WriteLine("");

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("¿Desea continuar? (S/N): ");
                Console.WriteLine("");
                string S = Console.ReadLine();
                Continuar = S.ToLower() == "s";
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Listado de Estudiantes:");

            Console.WriteLine("");

            Console.WriteLine("----------------------------------------------");
            foreach (var s in context.Estudiantes)
            {
              
                Console.WriteLine($"Nombre: {s.Nombre}, Apellido: {s.Apellido}, Sexo: {s.Sexo}, Edad: {s.Edad}");
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}


