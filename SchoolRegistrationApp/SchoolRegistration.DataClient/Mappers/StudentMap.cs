using SchoolRegistration.DataClient.DAOs;
using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolRegistration.DataClient.Mappers
{
   public class StudentMapper
   {
      public static StudentDAO MapToStudentDAO(Student student)
      {
         var s = new StudentDAO();

         s.StudentId = student.StudentId;
         s.FirstName = student.FirstName;
         s.LastName = student.LastName;
         s.Gender = student.Gender;
         s.Major = student.Major;
         s.Active = student.Active;

         return s;
      }
   }
}