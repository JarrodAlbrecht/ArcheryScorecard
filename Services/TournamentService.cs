
using ArcheryScorecard.Interfaces;
using ArcheryScorecard.Models;

namespace ArcheryScorecard.Services;

public class TournamentService : ITournamentService
{
    private readonly ITournamentRepository _tournamentRepository;

    public TournamentService(ITournamentRepository tournamentRepository)
    {
        _tournamentRepository = tournamentRepository;
    }

    public async Task<bool> ArchiveTournamentAsync(Tournament tournament)
    {
        tournament.IsArchived = true;
        return await _tournamentRepository.ArchiveAsync(tournament);
    }

    public async Task<bool> CreateTournamentAsync(Tournament tournament)
    {
        return await _tournamentRepository.AddAsync(tournament);
    }

    public async Task<bool> UpsertTournamentAsync(Tournament tournament)
    {
        return await _tournamentRepository.UpdateAsync(tournament);
    }

    public async Task<IEnumerable<Tournament>> GetCurrentTournamentsAsync()
    {
        return await _tournamentRepository.GetAllTournamentsAsync();
    }
}
