﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Interfaces
{
   public interface IStudent
   {
      string FirstName { get; }

      string LastName { get; }

      string Major { get; }
   }
}
