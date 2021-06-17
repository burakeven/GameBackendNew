using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            GamersCheckManager gamersCheckManager = new GamersCheckManager(new GamerManager());
            gamersCheckManager.Check(gamer);
           
        }

        public bool CheckGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Adlı kişinin kaydı sistemden silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Adlı kişinin kayıt güncelleme işlemi gerçekleştirildi.");
        }
    }
}
