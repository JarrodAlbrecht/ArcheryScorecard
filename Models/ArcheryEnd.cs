namespace ArcheryScorecard.Models;

public class ArcheryEnd
{
        public int Number { get; set; }
        public Dictionary<Guid, List<int>> ScoresByArcherId { get; set; } // Arrow scores
}
