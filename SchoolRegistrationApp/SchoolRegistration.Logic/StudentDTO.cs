using SchoolRegistration.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic
{
   public partial class StudentDTO : SubStudent
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

      internal StudentDTO() : base()
      {

      }

      internal override StudentDTO Create<StudentDTO>()
      {
         return new StudentDTO();
      }
   }
}
