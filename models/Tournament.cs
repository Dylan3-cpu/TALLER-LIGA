public class TournamentModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    public TournamentModel(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Nombre: {Name}";
    }
}
