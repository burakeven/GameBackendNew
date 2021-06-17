using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi." + " Oyunun fiyatı: " + game.GamePrice + " Oyunun kategorisi:" + game.GameCategory);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi.");
        }
    }
}
