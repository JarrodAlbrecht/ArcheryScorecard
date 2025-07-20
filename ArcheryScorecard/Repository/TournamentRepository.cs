using ArcheryScorecard.Models;

namespace ArcheryScorecard.Repository
{
    public class TournamentRepository : ITournamentRepository
    {
        public Task<IEnumerable<Tournament>> GetCurrentTournaments()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpsertTournament(Tournament tournament)
        {
            throw new NotImplementedException();
        }
    }
}
