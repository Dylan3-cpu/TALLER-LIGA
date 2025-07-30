// Clase para representar un equipo
public class TeamModel
{
    public int Id { get; set; } // Identificador del equipo
    public string Name { get; set; } // Nombre del equipo

    public TeamModel(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Nombre: {Name}";
    }
}

