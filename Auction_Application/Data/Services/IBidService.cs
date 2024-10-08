﻿using Auction_Application.Models;

namespace Auction_Application.Data.Services
{
    public interface IBidService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
