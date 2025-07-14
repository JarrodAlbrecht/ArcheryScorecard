
using ArcheryScorecard.Interfaces;
using ArcheryScorecard.Models;

namespace ArcheryScorecard.Repository;

public class TournamentRepository : ITournamentRepository
{
    private readonly ArcheryDbContext _context;

    public TournamentRepository(ArcheryDbContext context)
    {
        _context = context;
    }

    public Task<bool> AddAsync(Tournament tournament)
    {
        throw new NotImplementedException();
    }

    public Task<List<Tournament>> GetAllTournamentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Tournament>> GetArchivedTournamentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Tournament?> GetTournamentsByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Tournament tournament)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ArchiveAsync(Tournament tournament)
    {
        throw new NotImplementedException();
    }
}
