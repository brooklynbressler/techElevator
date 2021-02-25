using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("/")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet("auctions")]
        public List<Auction> ListAuctions(string title_like = "", double currentBid_lte = 0)
        {
            List<Auction> auction = dao.SearchByTitle(title_like);
            List<Auction> matchPrices = dao.SearchByPrice(currentBid_lte);
            List<Auction> matches = dao.SearchByTitleAndPrice(title_like, currentBid_lte);

            if (title_like != null && currentBid_lte != 0)
            {
                return matches;
            }
            else if (title_like == null && currentBid_lte != 0)
            {
                return matchPrices;
            }
            else if (title_like != null && currentBid_lte == 0)
            {
                return auction;
            }
            else
            {
                return dao.List();
            }

        }

        [HttpGet("auctions/{id}")]
        public Auction GetAuction(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }

            return null;
        }

        [HttpPost("auctions")]
        public Auction AddAuction(Auction auction)
        {
            return dao.Create(auction);
        }

    }

}
