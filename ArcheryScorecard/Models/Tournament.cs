using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using ArcheryScorecard.Enums;
using Microsoft.Extensions.FileSystemGlobbing;

namespace ArcheryScorecard.Models
{
    public class Tournament
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Tournament name is required.")]
        public string TournamentName { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Event type is required.")]
        public EventType EventType { get; set; }
        public List<Round> Rounds { get; set; } = new();
        public List<TournamentGroup> Groups { get; set; } = new();
        public TournamentStatus TournamentStatus { get; set; }
    }
}
