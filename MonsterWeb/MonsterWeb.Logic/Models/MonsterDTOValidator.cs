using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterWeb.Logic.Interfaces;

namespace MonsterWeb.Logic.Models
{
   public partial class MonsterDTO
   {
      internal override MonsterThing Create<T>()
      {
         return new 
      }

      partial void IsNull(ref string data, string value)
      {
         if (string.IsNullOrWhiteSpace(value))
         {
            return;
         }

        data = value;
      }
   }
}
