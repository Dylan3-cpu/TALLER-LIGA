public class TournamentModel //define clase publica para poder usar desde cualquier parte sin errores
{
    public int Id { get; set; } // la propiedad id es publica tambien lee y escribe el valor
    public string Name { get; set; } // lo mismo qeu id

    public TournamentModel(int id, string name) //pide el id y luego el nombre, id solo numero y nombre ya es texto
    {
        Id = id;
        Name = name;
    }

    public override string ToString() //muestra el id y el nombre del torneo
    {
        return $"ID: {Id} | Nombre: {Name}";
    }
}
