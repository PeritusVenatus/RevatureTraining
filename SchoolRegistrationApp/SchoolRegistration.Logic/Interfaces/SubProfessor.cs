using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Interfaces
{
   public abstract class SubProfessor : IProfessor
   {
      public virtual string FirstName { get; set; }

      public virtual string LastName { get; set; }

      public virtual string Department { get; set; }

      internal SubProfessor()
      {
         FirstName = "None";
         LastName = "None";
         Department = "None";
      }

      internal abstract T Create<T>() where T : new();
   }
}
