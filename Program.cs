using System;
using System.Collections.Generic;

class Tournament
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Tournament(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Nombre: {Name}";
    }
}

class Program
{
    static List<Tournament> tournaments = new List<Tournament>();

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-       CREAR TORNEOS       -");
            Console.WriteLine("- 1. AGREGAR TORNEO.        -");
            Console.WriteLine("- 2. BUSCAR TORNEOS.        -");
            Console.WriteLine("- 3. ELIMINAR TORNEOS.      -");
            Console.WriteLine("- 4. ACTUALIZAR TORNEOS.    -");
            Console.WriteLine("- 5. REGRESAR MAIN MENU.    -");
            Console.WriteLine("-----------------------------");
            Console.Write("Selecciona una opción (1 - 5): ");
            string opcion = Console.ReadLine() ?? string.Empty;

            switch (opcion)
            {
                case "1":
                    AgregarTorneo();
                    break;
                case "2":
                    BuscarTorneo();
                    break;
                case "3":
                    EliminarTorneo();
                    break;
                case "4":
                    ActualizarTorneo();
                    break;
                case "5":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no valida.");
                    break;
            }

            Console.WriteLine("Presiona ENTER para volver al menu");
            Console.ReadLine();
        }
    }

    static void AgregarTorneo()
    {
        Console.Write("Ingrese el ID del torneo: ");
        string input = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        Console.Write("Ingrese el nombre del torneo: ");
        string nombre = Console.ReadLine() ?? string.Empty;

        tournaments.Add(new Tournament(id, nombre));
        Console.WriteLine("Torneo agregado correctamente.");
    }

    static void BuscarTorneo()
    {
        Console.Write("Ingrese el ID del torneo a buscar: ");
        string inputBuscar = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(inputBuscar) || !int.TryParse(inputBuscar, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        foreach (var torneo in tournaments)
        {
            if (torneo.Id == id)
            {
                Console.WriteLine("Torneo encontrado:");
                Console.WriteLine(torneo);
                return;
            }
        }

        Console.WriteLine("Torneo no encontrado.");
    }

    static void EliminarTorneo()
    {
        Console.Write("Ingrese el ID del torneo a eliminar: ");
        string inputEliminar = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(inputEliminar) || !int.TryParse(inputEliminar, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        for (int i = 0; i < tournaments.Count; i++)
        {
            if (tournaments[i].Id == id)
            {
                tournaments.RemoveAt(i);
                Console.WriteLine("Torneo eliminado correctamente.");
                return;
            }
        }

        Console.WriteLine("Torneo no encontrado.");
    }

    static void ActualizarTorneo()
    {
        Console.Write("Ingrese el ID del torneo a actualizar: ");
        string inputActualizar = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(inputActualizar) || !int.TryParse(inputActualizar, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        foreach (var torneo in tournaments)
        {
            if (torneo.Id == id)
            {
                Console.Write("Nuevo nombre del torneo: ");
                torneo.Name = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Torneo actualizado.");
                return;
            }
        }

        Console.WriteLine("Torneo no encontrado.");
    }
}
