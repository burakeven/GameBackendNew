using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaigns campaign);
    }
}
