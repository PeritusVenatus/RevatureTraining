using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrationDataClient
{
   [DataContract]
   public class StudentDAO
   {
      [DataMember]
      public int StudentId { get; set; }

      [DataMember]
      public string FirstName { get; set; }

      [DataMember]
      public string LastName { get; set; }

      [DataMember]
      public int Gender { get; set; }

      [DataMember]
      public string Major { get; set; }

      [DataMember]
      public bool Active { get; set; }
   }
}
