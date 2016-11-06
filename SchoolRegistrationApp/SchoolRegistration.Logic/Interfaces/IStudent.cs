using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Interfaces
{
   public interface IStudent
   {
      Guid Id { get; }

      string Name { get; }

      DateTime Creation { get; }
   }
}
