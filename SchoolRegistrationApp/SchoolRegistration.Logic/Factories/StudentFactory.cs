using SchoolRegistration.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Factories
{
   public class StudentFactory<T> where T : SubStudent, new()
   {
      public T Create()
      {
         var o = new T();
         return o.Create<T>();
      }
   }
}
