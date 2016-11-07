using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Interfaces
{
   public interface IProfessor
   {
      string FirstName { get; }

      string LastName { get; }

      string Department { get; }
   }
}
