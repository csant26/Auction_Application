using Auction_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Auction_Application.Data.Services
{
    public class BidService : IBidService
    {
        private readonly ApplicationDbContext _context;
        public BidService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Bid bid)
        {
            _context.Bids.Add(bid);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Bid> GetAll()
        {
            var applicationDbContext = _context.Bids.Include(l => l.Listing).ThenInclude(u => u.User);
            //var applicationDbContext = from a in _context.Bids.Include(l => l.Listing).ThenInclude(u => u.User) select a;
            return applicationDbContext;
        }
    }
}
