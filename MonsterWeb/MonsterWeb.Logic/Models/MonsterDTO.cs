using MonsterWeb.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Models
{
   public partial class MonsterDTO : MonsterThing
   {
      private string _Name = default(string);

      partial void IsNull(ref string data, string value);

      public override string Name
      {
         get
         {
            return _Name;
         }

         protected set
         {
            IsNull(ref _Name, value);
         }
      }

      public new DateTime Creation { get; set; }

      public GenderDTO Gender { get; set; }
      public TitleDTO Title { get; set; }
      public TypeDTO Type { get; set; }

      public MonsterDTO(string name) : base()
      {
         //int tempGender;
         //int tempType;
         //int.TryParse(genderId, out tempGender);
         //int.TryParse(typeId, out tempType);
         //Name = name;
         //GenderId = tempGender;
         //TypeId = tempType;

         
         Name = name;
      }

      ~MonsterDTO()
      {
         GC.Collect();
      }
   }
}
