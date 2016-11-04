using MonsterWeb.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Models
{
   public partial class GenderDTO : MonsterThing
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

      internal GenderDTO() : base()
      {

      }

      internal override GenderDTO Create<GenderDTO>()
      {
         return new GenderDTO();
      }
   }
}
