﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SchoolRegistration.DataClient.DAOs
{
   [DataContract]
   public class ProfessorDAO
   {
      [DataMember]
      public int ProfessorId { get; set; }

      [DataMember]
      public string FirstName { get; set; }

      [DataMember]
      public string LastName { get; set; }

      [DataMember]
      public string Department { get; set; }

      [DataMember]
      public bool Active { get; set; }
   }
}