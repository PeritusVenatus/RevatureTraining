﻿using MonsterWeb.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic
{
   public class FactoryThing<T> where T : MonsterThing, new()
   {
      public T Create() 
      {
         return new T().Create<T>();
      }
   }
}
