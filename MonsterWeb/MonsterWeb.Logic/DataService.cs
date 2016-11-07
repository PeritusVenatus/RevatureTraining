using MonsterWeb.Logic.Models;
using MonsterWeb.Logic.MonsterServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic
{
  public class DataService
  {
      private MonsterServiceClient msc = new MonsterServiceClient();
      private FactoryThing<GenderDTO> genderFactory = new FactoryThing<GenderDTO>();
      public List<GenderDTO> GetGenders()
    {
         var genders = new List<GenderDTO>();

         foreach (var item in msc.GetGenders())
         {
            var g = genderFactory.Create();

            g.AppId = item.Id;
            g.Name = item.Name;

            genders.Add(g);
         }

         return genders;
    }

      public bool InsertMonster(GenderDTO gender)
      {
         var gen = msc.GetGenders().FirstOrDefault(g => g.Id == gender.AppId);
         var mon = new MonsterDAO() { Name = gender.Name, Gender = gen, Type = new MonsterTypeDAO() { Id = 1 } };

         return msc.InsertMonster(mon);
      }
   }
}
