using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Registration.DataClient.Models
{
   [DataContract]
   public class CourseDAO
   {
      [DataMember]
      public int CourseId { get; set; }

      [DataMember]
      public string CourseName { get; set; }

      [DataMember]
      public int CreditHours { get; set; }

      [DataMember]
      public int Capacity { get; set; }

      [DataMember]
      public string Department { get; set; }

      [DataMember]
      public int ClassDuration { get; set; }

      [DataMember]
      public TimeSpan ClassTime1 { get; set; }

      [DataMember]
      public TimeSpan ClassTime2 { get; set; }

      [DataMember]
      public TimeSpan ClassTime3 { get; set; }

      [DataMember]
      public bool Active { get; set; }
   }
}
