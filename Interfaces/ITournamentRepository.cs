using ArcheryScorecard.Models;

namespace ArcheryScorecard.Interfaces;

public interface ITournamentRepository
{
    Task<bool> AddAsync(Tournament tournament);
    Task<bool> UpdateAsync(Tournament tournament);
    Task<bool> ArchiveAsync(Tournament tournament);
    Task<Tournament?> GetTournamentsByIdAsync(Guid id);
    Task<List<Tournament>> GetAllTournamentsAsync();
    Task<List<Tournament>> GetArchivedTournamentsAsync();
}
