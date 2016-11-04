using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MonsterApp.DataClient.Models;
using MonsterApp.DataAccess;

namespace MonsterApp.DataClient
{
  public class MonsterService : IMonsterService
  {
    private AdoData data = new AdoData();
      private EfData ef = new EfData();

    public List<GenderDAO> GetGenders()
    {
      var g = new List<GenderDAO>();

      foreach (var gender in data.GetGenders())
      {
        g.Add(GenderMapper.MapToGenderDAO(gender));
      }

      return g;
    }

    public List<MonsterTypeDAO> GetMonsterTypes()
    {
      throw new NotImplementedException();
    }

    public List<TitleDAO> GetTitles()
    {
      throw new NotImplementedException();
    }

      public bool InsertMonster(MonsterTypeDAO monster)
      {
         var m = new Monster();

         m.Name = monster.Name;
         m.GenderId = monster.Gender.Id;
         m.TypeId = monster.Type.Id;

         return ef.InsertMonster(m);
      }

  }
}
