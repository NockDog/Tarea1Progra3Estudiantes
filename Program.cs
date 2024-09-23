using System;
using System.Collections.Generic;

public class Estudiante
{
    public string Nombre { get; set; }
    private int Edad { get; set; }
    public double Promedio { get; set; }

    public Estudiante(string nombre, int edad, double promedio)
    {
        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
    }

    public bool EsMayorDeEdad()
    {
        return Edad >= 18;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Promedio: {Promedio}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Solicita al usuario la cantidad de estudiantes a registrar
        Console.WriteLine("Ingrese la cantidad de estudiantes a registrar:");
        int cantidadEstudiantes = int.Parse(Console.ReadLine());

        // Lista para almacenar los objetos de la clase Estudiante
        List<Estudiante> estudiantes = new List<Estudiante>();

        // Ciclo for para registrar cada estudiante
        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Promedio: ");
            double promedio = double.Parse(Console.ReadLine());

            // Crear una nueva instancia de Estudiante y agregarla a la lista
            estudiantes.Add(new Estudiante(nombre, edad, promedio));
        }

        // Ciclo para mostrar la información de los estudiantes con promedio >= 70
        Console.WriteLine("\nEstudiantes con un promedio mayor o igual a 70:");
        foreach (var estudiante in estudiantes)
        {
            if (estudiante.Promedio >= 70)
            {
                estudiante.MostrarInfo();

                // Verificar si el estudiante es mayor de edad y mostrar mensaje correspondiente
                if (estudiante.EsMayorDeEdad())
                {
                    Console.WriteLine($"{estudiante.Nombre} es mayor de edad.");
                }
                else
                {
                    Console.WriteLine($"{estudiante.Nombre} no es mayor de edad.");
                }
            }
        }

        // Esperar a que el usuario presione Enter para salir
        Console.WriteLine("\nPresione Enter para salir...");
        Console.ReadLine();
    }
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
