public class CreateTeams
{
    static List<TeamModel> teams = new List<TeamModel>();
    public static void Mostrar()
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-      CREAR EQUIPOS        -");
            Console.WriteLine("- 1. AGREGAR EQUIPO.        -");
            Console.WriteLine("- 2. BUSCAR EQUIPO.         -");
            Console.WriteLine("- 3. ELIMINAR EQUIPO.       -");
            Console.WriteLine("- 4. ACTUALIZAR EQUIPO.     -");
            Console.WriteLine("- 5. REGRESAR MAIN MENU.    -");
            Console.WriteLine("-----------------------------");
            Console.Write("Selecciona una opción (1 - 5): ");
            string opcion = Console.ReadLine() ?? string.Empty;

            switch (opcion)
            {
                case "1":
                    AgregarEquipo();
                    break;
                case "2":
                    BuscarEquipo();
                    break;
                case "3":
                    EliminarEquipo();
                    break;
                case "4":
                    ActualizarEquipo();
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
    static void AgregarEquipo()
    {
        Console.Write("Ingrese el ID del equipo: ");
        string input = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        Console.Write("Ingrese el nombre del equipo: ");
        string nombre = Console.ReadLine() ?? string.Empty;
        teams.Add(new TeamModel(id, nombre));
        Console.WriteLine("Equipo agregado correctamente.");
    }
    static void BuscarEquipo()
    {
        Console.Write("Ingrese el ID del equipo a buscar: ");
        string inputBuscar = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(inputBuscar) || !int.TryParse(inputBuscar, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        foreach (var equipo in teams)
        {
            if (equipo.Id == id)
            {
                Console.WriteLine("Equipo encontrado:");
                Console.WriteLine(equipo);
                return;
            }
        }
        Console.WriteLine("Equipo no encontrado.");
    }
    static void EliminarEquipo()
    {
        Console.Write("Ingrese el ID del equipo a eliminar: ");
        string inputEliminar = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(inputEliminar) || !int.TryParse(inputEliminar, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        for (int i = 0; i < teams.Count; i++)
        {
            if (teams[i].Id == id)
            {
                teams.RemoveAt(i);
                Console.WriteLine("Equipo eliminado correctamente.");
                return;
            }
        }
        Console.WriteLine("Equipo no encontrado.");
    }
    static void ActualizarEquipo()
    {
        Console.Write("Ingrese el ID del equipo a actualizar: ");
        string inputActualizar = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(inputActualizar) || !int.TryParse(inputActualizar, out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        foreach (var equipo in teams)
        {
            if (equipo.Id == id)
            {
                Console.Write("Nuevo nombre del equipo: ");
                equipo.Name = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Equipo actualizado.");
                return;
            }
        }
        Console.WriteLine("Equipo no encontrado.");
    }
}