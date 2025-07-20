using ArcheryScorecard.Models;
using ArcheryScorecard.Repository;

namespace ArcheryScorecard.Services
{
    public class TournamentService : ITournamentService
    {
        public ITournamentRepository _tournamentRepository { get; set; }

        public TournamentService(ITournamentRepository tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        public async Task<IEnumerable<Tournament>> GetCurrentTournamentsAsync()
        {
            return await _tournamentRepository.GetCurrentTournaments();
        }

        public async Task<bool> UpsertTournamentAsync(Tournament tournament)
        {
            return await _tournamentRepository.UpsertTournament(tournament);
        }
    }
}
