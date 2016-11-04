using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Interfaces
{
   public abstract class MonsterThing : IThing
   {
      public Guid Id { get; }

      public int AppId { get; set; }

      public virtual string Name { get; protected set; }

      public DateTime Creation { get; }

      internal MonsterThing()
      {
         Id = Guid.NewGuid();
         Name = "None";
         Creation = DateTime.Now;
      }

      internal abstract MonsterThing Create<T>() where T : new();

   }
}
