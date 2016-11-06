using SchoolRegistration.DataClient.DAOs;
using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolRegistration.DataClient.Mappers
{
   public class CourseMapper
   {
      public static CourseDAO MapToCourseDAO(Cours course)
      {
         var c = new CourseDAO();

         c.CourseId = course.CourseId;
         c.Department = course.Department;
         c.CourseName = course.CourseName;
         c.CreditHours = course.CreditHours;
         c.Capacity = course.Capacity;
         c.ClassDuration = course.ClassRunTime;
         c.ClassTime1 = course.ClassTime1;
         c.ClassTime2 = course.ClassTime2;
         c.ClassTime3 = course.ClassTime3;
         c.Active = course.Active;

         return c;
      }
   }
}