using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaigns campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName+ " oyunu" + gamer.FirstName + gamer.LastName + " adlı kişiye satıldı.");
            Console.WriteLine("Oyunun indirimli fiyatı: " + newPrice+ " TL");
            Console.WriteLine("Uygulanan indirim: " + (game.GamePrice-newPrice) + " TL");
        }
    }
}
