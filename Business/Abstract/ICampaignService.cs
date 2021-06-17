using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Update(Campaigns campaign);
        void Delete(Campaigns campaign);
    }
}
