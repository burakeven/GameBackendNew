using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //oyuncu girisi
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Burak";
            gamer1.LastName = "Even";
            gamer1.NationalityId = 37666030270;
            gamer1.DateOfBirthYear = 1999;

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Merve";
            gamer2.LastName = "Acar";
            gamer2.NationalityId = 12345678901;
            gamer2.DateOfBirthYear = 1999;

            //oyun girisi
            Game game1 = new Game();
            game1.GameName = "Crysis4";
            game1.GamePrice = 180;
            game1.GameCategory = "Aksiyon";

            Game game2 = new Game();
            game2.GameName = "Cabal Online";
            game2.GamePrice = 60;
            game2.GameCategory = "MMORPG";

            //kampanya girisi
            Campaigns campaign1 = new Campaigns();
            campaign1.CampaignName = "Yaz indirimi";
            campaign1.CampaignDiscount = 50;

            Campaigns campaign2 = new Campaigns();
            campaign2.CampaignName = "Keyfe keder indirim";
            campaign2.CampaignDiscount = 25;

            //Oyuncu yönetimi
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);

            GamerManager gamerManager2 = new GamerManager();
            gamerManager2.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer2);

            //Oyun yönetimi
            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            gameManager1.Delete(game1);
            GameManager gameManager2 = new GameManager();
            gameManager2.Add(game2);
            gameManager2.Update(game2);

            //Kampanya yönetimi
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);

            //oyun satış bölümü
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaign1);

            Console.ReadLine();
        }
    }
}
