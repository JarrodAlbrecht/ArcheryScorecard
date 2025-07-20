public class ScoreEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ArcherId { get; set; }
    public Guid EndId { get; set; }

    public List<int> ArrowScores { get; set; } = new(); // 6 values for 6 arrows

    public int Total => ArrowScores.Sum();
}
