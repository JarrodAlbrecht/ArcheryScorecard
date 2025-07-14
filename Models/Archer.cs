using ArcheryScorecard.Models.Enums;

namespace ArcheryScorecard.Models;

public class Archer
{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BowStyle Bow { get; set; }
        public string Division { get; set; }
}
