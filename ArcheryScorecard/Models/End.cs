public class End
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int EndNumber { get; set; }
    public Guid RoundId { get; set; }

    public List<ScoreEntry> Scores { get; set; } = new();
}
