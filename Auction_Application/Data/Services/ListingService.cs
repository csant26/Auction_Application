using Auction_Application.Models;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace Auction_Application.Data.Services
{
    public class ListingService : IListingService
    {
        private readonly ApplicationDbContext _context;
        public ListingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext; 
        }
    }
}
