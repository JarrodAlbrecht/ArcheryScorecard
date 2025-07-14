
using ArcheryScorecard.Interfaces;
using ArcheryScorecard.Models;

namespace ArcheryScorecard.Services;

public class TournamentService : ITournamentService
{
    private readonly ITournamentRepository _repo;

    public TournamentService(ITournamentRepository repo)
    {
        _repo = repo;
    }
    public async Task<bool> ArchiveTournamentAsync(Tournament tournament)
    {
        tournament.IsArchived = true;
        return await _repo.ArchiveAsync(tournament);
    }

    public async Task<bool> CreateTournamentAsync(Tournament tournament)
    {
        return await _repo.AddAsync(tournament);
    }

    public async Task<bool> UpsertTournamentAsync(Tournament tournament)
    {
        return await _repo.UpdateAsync(tournament);
    }
}
