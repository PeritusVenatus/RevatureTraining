using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Interfaces
{
   public abstract class SubStudent : IStudent
   {
      public Guid Id { get; }

      public virtual string Name { get; protected set; }

      public DateTime Creation { get; }

      internal SubStudent()
      {
         Id = Guid.NewGuid();
         Name = "None";
         Creation = DateTime.Now;
      }

      internal abstract SubStudent Create<T>() where T : new();
   }
}
