using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class GamersCheckManager
    {
        private IGamerService _gamerService;
        public GamersCheckManager(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }
        public void Check(Gamer gamer)
        {
            if (_gamerService.CheckGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu Mernis veritabanında bulundu, geçerli kişi.");
                Console.WriteLine(gamer.FirstName + " adlı oyuncunun kaydı yapılmıştır.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu Mernis veritabanında bulunamadı, geçersiz kişi.");
                Console.WriteLine(gamer.FirstName+ " adlı oyuncunun sisteme kaydı yapılamamıştır.");
            }
        }
    }
}
