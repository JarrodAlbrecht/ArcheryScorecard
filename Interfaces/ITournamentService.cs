using ArcheryScorecard.Models;

namespace ArcheryScorecard.Interfaces;

public interface ITournamentService
{
    public Task<bool> CreateTournamentAsync(Tournament tournament);

    public Task<bool> UpsertTournamentAsync(Tournament tournament);

    public Task<bool> ArchiveTournamentAsync(Tournament tournament);
}
