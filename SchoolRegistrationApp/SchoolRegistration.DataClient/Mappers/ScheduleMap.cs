using SchoolRegistration.DataClient.DAOs;
using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolRegistration.DataClient.Mappers
{
   public class ScheduleMapper
   {
      public static ScheduleDAO MapToScheduleDAO(Schedule schedule)
      {
         var s = new ScheduleDAO();

         s.ScheduleId = schedule.ScheduleId;
         s.StudentId = schedule.StudentId;
         s.ProfessorId = schedule.ProfessorId;

         s.Course1Id = schedule.Course1Id;
         s.Course1Time = schedule.Course1Time;

         s.Course2Id = schedule.Course2Id;
         s.Course2Time = schedule.Course2Time;

         s.Course3Id = schedule.Course3Id;
         s.Course3Time = schedule.Course3Time;

         s.Course4Id = schedule.Course4Id;
         s.Course4Time = schedule.Course4Time;

         s.Course5Id = schedule.Course5Id;
         s.Course5Time = schedule.Course5Time;

         s.Course6Id = schedule.Course6Id;
         s.Course6Time = schedule.Course6Time;

         s.Course7Id = schedule.Course7Id;
         s.Course7Time = schedule.Course7Time;

         return s;
      }
   }
}