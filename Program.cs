using System;
using System.Collections.Generic;

namespace CRUDExample
{
    class Program
    {
        static List<string> names = new List<string>();

        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("CRUD APP");
                Console.WriteLine("1. Crear");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Elige una opcion: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void Create()
        {
            Console.Write("Pon un nombre para añadir: ");
            string name = Console.ReadLine();
            names.Add(name);
            Console.WriteLine("Nombre añadido!");
        }

        static void Read()
        {
            Console.WriteLine("Lista de nombres:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }
        }

        static void Update()
        {
            Console.Write("Pon el nombre de quien quieres actualizar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <= names.Count)
            {
                Console.Write($"Poner nombre {index}: ");
                string newName = Console.ReadLine();
                names[index - 1] = newName;
                Console.WriteLine("Nombre actualizado correctamente!");
            }
            else
            {
                Console.WriteLine("Index no valido");
            }
        }

        static void Delete()
        {
            Console.Write("Pon nombre a borrar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <= names.Count)
            {
                names.RemoveAt(index - 1);
                Console.WriteLine("Nombre borrado correctamente!");
            }
            else
            {
                Console.WriteLine("Index no valido");
            }
        }
    }
}
