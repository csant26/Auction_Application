﻿using Auction_Application.Models;
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

        public async Task Add(Listing listing)
        {
            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext; 
        }

        public async Task<Listing> GetById(int? id)
        {
            var listing = await _context.Listings
                .Include(l => l.User)
                .Include(l => l.Comments)
                .Include(l => l.Bids)
                .ThenInclude(l=>l.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            return listing;
        }
    }
}
