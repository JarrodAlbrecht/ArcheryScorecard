public class TournamentGroup
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string GroupName { get; set; } // e.g., Group A, Target 1

    public List<Archer> Archers { get; set; } = new();
}
