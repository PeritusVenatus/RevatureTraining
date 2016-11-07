using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Interfaces
{
   public abstract class SubCourse : ICourse
   {
      public virtual string CourseName { get; set; }

     // public virtual int CreditHours { get; protected set; }

     // public virtual int Capacity { get; protected set; }

      internal SubCourse()
      {
         CourseName = "None";
         //CreditHours = 0;
        // Capacity = 0;
      }

      internal abstract T Create<T>() where T : new();
   }
}
