using SchoolRegistration.DataClient.DAOs;
using SchoolRegistration.DataClient.Mappers;
using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SchoolRegistration.DataClient
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Registration" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Registration.svc or Registration.svc.cs at the Solution Explorer and start debugging.
   public class Registration : IRegistration
   {
      private EFData ef = new EFData();

      public List<StudentDAO> GetStudents()
      {
         var s = new List<StudentDAO>();

         foreach (var students in ef.GetStudents())
         {
            s.Add(StudentMapper.MapToStudentDAO(students));
         }

         return s;
      }

      public List<ProfessorDAO> GetProfessors()
      {
         var p = new List<ProfessorDAO>();

         foreach (var professors in ef.GetProfessors())
         {
            p.Add(ProfessorMapper.MapToProfessorDAO(professors));
         }

         return p;
      }

      public List<CourseDAO> GetCourses()
      {
         var c = new List<CourseDAO>();

         foreach (var courses in ef.GetCourses())
         {
            c.Add(CourseMapper.MapToCourseDAO(courses));
         }

         return c;
      }

      public List<ScheduleDAO> GetSchedules()
      {
         var s = new List<ScheduleDAO>();

         foreach (var schedules in ef.GetSchedules())
         {
            s.Add(ScheduleMapper.MapToScheduleDAO(schedules));
         }

         return s;
      }

      //public bool InsertStudent(StudentDAO student)
      //{
      //   var s = new Student();

      //   s.FirstName = student.FirstName;
      //   s.LastName = student.LastName;
      //   s.Gender = student.Gender;
      //   s.Major = student.Major;

      //   return ef.Run_AddStudent(s.FirstName, s.LastName, s.Gender, s.Major);
      //}
   }
}
