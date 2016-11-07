using SchoolRegistration.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic
{
   public class CourseDTO : SubCourse
   {

      private string _Name = default(string);

      public override string CourseName
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

      internal override CourseDTO Create<CourseDTO>()
      {
         return new CourseDTO();
      }

      private void IsNull(ref string data, string value)
      {
         if (string.IsNullOrWhiteSpace(value))
         {
            return;
         }

         data = value;
      }
   }
}
