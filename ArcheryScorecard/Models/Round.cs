public class Round
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int DistanceMeters { get; set; }
    public int TargetFaceSizeCm { get; set; }
    public int NumberOfEnds { get; set; }
    public int ArrowsPerEnd { get; set; }

    public List<End> Ends { get; set; } = new();
}
