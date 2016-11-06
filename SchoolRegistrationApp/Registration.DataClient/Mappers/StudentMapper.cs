﻿using Registration.DataClient.Models;
using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.DataClient.Mappers
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
