using SchoolRegistration.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic
{
   public class StudentDTO : SubStudent
   {
      private string _Name = default(string);

      public override string FirstName
      {
         get
         {
            return _Name;
         }

         set
         {
            IsNull(ref _Name, value);
         }
      }

      public override string LastName
      {
         get
         {
            return _Name;
         }

         set
         {
            IsNull(ref _Name, value);
         }
      }

      public override string Major
      {
         get
         {
            return _Name;
         }

         set
         {
            IsNull(ref _Name, value);
         }
      }

      public StudentDTO() : base()
      {

      }

      internal override StudentDTO Create<StudentDTO>()
      {
         return new StudentDTO();
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
