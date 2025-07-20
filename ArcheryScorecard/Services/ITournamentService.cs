using ArcheryScorecard.Models;

namespace ArcheryScorecard.Services
{
    public interface ITournamentService
    {
        public Task<IEnumerable<Tournament>> GetCurrentTournamentsAsync();

        public Task<bool> UpsertTournamentAsync(Tournament tournament);
    }
}
