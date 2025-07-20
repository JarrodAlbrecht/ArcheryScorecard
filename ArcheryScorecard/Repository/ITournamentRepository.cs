using ArcheryScorecard.Models;

namespace ArcheryScorecard.Repository
{
    public interface ITournamentRepository
    {
        public Task<IEnumerable<Tournament>> GetCurrentTournaments();

        public Task<bool> UpsertTournament(Tournament tournament);
    }
}
