using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SchoolRegistration.DataClient.DAOs
{
   [DataContract]
   public class ScheduleDAO
   {
      [DataMember]
      public int? ScheduleId { get; set; }

      [DataMember]
      public int? ProfessorId { get; set; }

      [DataMember]
      public int? StudentId { get; set; }

      [DataMember]
      public int? Course1Id { get; set; }

      [DataMember]
      public TimeSpan? Course1Time { get; set; }

      [DataMember]
      public int? Course2Id { get; set; }

      [DataMember]
      public TimeSpan? Course2Time { get; set; }

      [DataMember]
      public int? Course3Id { get; set; }

      [DataMember]
      public TimeSpan? Course3Time { get; set; }

      [DataMember]
      public int? Course4Id { get; set; }

      [DataMember]
      public TimeSpan? Course4Time { get; set; }

      [DataMember]
      public int? Course5Id { get; set; }

      [DataMember]
      public TimeSpan? Course5Time { get; set; }

      [DataMember]
      public int? Course6Id { get; set; }

      [DataMember]
      public TimeSpan? Course6Time { get; set; }

      [DataMember]
      public int? Course7Id { get; set; }

      [DataMember]
      public TimeSpan? Course7Time { get; set; }

      [DataMember]
      public bool Active { get; set; }

   }
}