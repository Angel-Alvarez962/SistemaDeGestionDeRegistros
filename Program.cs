using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GestionRegistro
{
    class Program
    {
        static void Main(string[] args)
        {
            Register registro = new Register();
            int opcion;

            registro.Add("Carlos Ruiz", 99.9, 1023);
            registro.Add("Ana López", 91.7, 1001);
            registro.Add("Miguel Torres", 78.9, 1042);
            registro.Add("Lucía Fernández", 88.3, 1015);
            registro.Add("Jorge Castillo", 73.5, 1090);
            registro.Add("Sofía Martínez", 95.2, 1030);
            registro.Add("David Gómez", 82.1, 1077);
            registro.Add("Elena Ríos", 89.5, 1060);
            registro.Add("Roberto Sánchez", 76.8, 1088);
            registro.Add("María Pérez", 90.0, 1055);

            do
            {
                Console.Clear();
                Console.WriteLine("=== Menú de Gestión de Estudiantes ===");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Mostrar estudiantes");
                Console.WriteLine("3. Ordenar por nombre");
                Console.WriteLine("4. Ordenar por matrícula");
                Console.WriteLine("5. Ordenar por promedio");
                Console.WriteLine("6. Buscar por matrícula");
                Console.WriteLine("7. Buscar por nombre");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Promedio: ");
                        if (!double.TryParse(Console.ReadLine(), out double promedio))
                        {
                            Console.WriteLine("Promedio inválido.");
                            break;
                        }

                        Console.Write("Matrícula: ");
                        if (!int.TryParse(Console.ReadLine(), out int matricula))
                        {
                            Console.WriteLine("Matrícula inválida.");
                            break;
                        }

                        registro.Add(nombre, promedio, matricula);
                        Console.WriteLine("Estudiante agregado.");
                        break;

                    case 2:
                        Console.WriteLine("Lista de estudiantes:");
                        registro.Show();
                        break;

                    case 3:
                        registro.QuickSortName();
                        Console.WriteLine("Estudiantes ordenados por nombre.");
                        registro.Show();
                        break;

                    case 4:
                        registro.QuickSortID();
                        Console.WriteLine("Estudiantes ordenados por matrícula.");
                        registro.Show();
                        break;

                    case 5:
                        registro.QuickSortGrade();
                        Console.WriteLine("Estudiantes ordenados por promedio.");
                        registro.Show();
                        break;

                    case 6:
                        Console.Write("Ingrese la matrícula a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int matBuscar))
                        {
                            registro.BinarySearch(matBuscar);
                        }
                        else
                        {
                            Console.WriteLine("Matrícula inválida.");
                        }
                        break;

                    case 7:
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombreBuscar = Console.ReadLine();
                        registro.BinarySearch(nombreBuscar);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}