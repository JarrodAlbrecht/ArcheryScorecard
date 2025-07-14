using ArcheryScorecard.Models.Enums;

namespace ArcheryScorecard.Models;

public class Tournament
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public TournamentType Type { get; set; }
    public DateTime Date { get; set; }
    public List<Archer> Archers { get; set; }
    public List<ArcheryEnd> ArcheryEnds { get; set; }
    public BowStyle BowStyle { get; set; }
    public bool IsArchived { get; set; }
    public List<int> TournamentShootingDistances { get; set; }
    public List<ShootingRound> Rounds { get; set; }
}
