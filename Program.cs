using System;
class Program
{
    static void Main(string[] args)
    {
        // Variable que va almacenar lo que ingrese el usuario 
        int opcion;
        do
        {
            // Bloque de codigo del menu principal
            Console.Clear();
            Console.WriteLine("==== MENU PRINCIPAL ====");
            Console.WriteLine("1. Crear Torneo");
            Console.WriteLine("2. Registro Equipos");
            Console.WriteLine("3. Registro Jugadores");
            Console.WriteLine("4. Transferencias (Compra, Préstamo)");
            Console.WriteLine("5. Estadísticas");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            // Condicion que evalua que la opcion sea valida
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida\nPresione una tecla para reintentar...");
                Console.ReadKey();
                continue;
            }

            // Evalua el entero guardado en la variable opcion
            switch (opcion)
            {
                case 1:
                    // Llama al submenú de torneos
                    Create.Mostrar(); // Cambio TournamentModel.Mostrar() por Create.Mostrar()
                    break;
                case 2:
                    CreateTeams.Mostrar(); // Llama al submenú de equipos
                    break;
                case 3:
                    Console.WriteLine("Registro de Jugadores...");
                    break;
                case 4:
                    Console.WriteLine("Transferencias (Compra, Préstamo)...");
                    break;
                case 5:
                    Console.WriteLine("Mostrando Estadísticas...");
                    break;
                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
            }
// Comentario: Se corrigió la llamada al menú de torneos, ahora usa Create.Mostrar()
            //Evalua si el entero es mayor que 5 imprime ese mensaje 
            if (opcion != 6)
            {
                Console.WriteLine("La opcion ingresada supera el rango de opciones.\nPresione cualquier tecla para reintentar...");
                Console.ReadKey();
            }
        // Condicion para que termine el ciclo 
        } while (opcion != 6);
    }
}
