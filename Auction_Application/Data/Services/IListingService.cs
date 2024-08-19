using Auction_Application.Models;

namespace Auction_Application.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
    }
}
