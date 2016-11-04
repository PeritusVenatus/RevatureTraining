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
         }

         return genders;
    }

      public bool InsertMonster(GenderDTO)
      {
         var gen = msc.GetGenders().FirstOrDefault(g => g.Id == gender.AppId);

         var mon = new MonsterDAO() { Name = gender.Name, Gender = gender, Type = new MonsterTypeDAO() };

         return msc.InsertMonster(mon);
      }
  }
}
