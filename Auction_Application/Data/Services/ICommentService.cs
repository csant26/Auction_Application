using Auction_Application.Models;

namespace Auction_Application.Data.Services
{
    public interface ICommentService
    {
        Task Add(Comment comment);
    }
}
