﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic.Interfaces
{
   public abstract class SubStudent : IStudent
   {
      public virtual string FirstName {get; protected set;}

      public virtual string LastName { get; protected set; }

      public virtual string Major { get; protected set; }

      internal SubStudent()
      {
         FirstName = "None";
         LastName = "None";
         Major = "None";
      }

      internal abstract T Create<T>() where T : new();
   }
}
