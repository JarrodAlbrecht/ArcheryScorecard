using ArcheryScorecard.Models;

namespace ArcheryScorecard.Interfaces;

public interface ITournamentRepository
{
    Task<bool> AddAsync(Tournament tournament);
    Task<bool> UpdateAsync(Tournament tournament);
    Task<bool> ArchiveAsync(Tournament tournament);
    Task<Tournament?> GetByIdAsync(Guid id);
    Task<List<Tournament>> GetAllAsync();
    Task<List<Tournament>> GetArchivedAsync();
}
