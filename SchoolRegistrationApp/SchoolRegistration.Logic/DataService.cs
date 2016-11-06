using SchoolRegistration.DataClient.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic
{
   public class DataService
   {
      public List<StudentDTO> GetStudents()
      {
         var students = new List<StudentDTO>();

         foreach (var item in GetStudents())
         {
            var s = studentFactory.Create();
         }

         return students;
      }

      public List<ProfessorDTO> GetProfessors()
      {
         var professors = new List<ProfessorDTO>();

         foreach (var item in GetProfessors())
         {
            var p = ProfessorFactory.Create();
         }

         return professors;
      }

      public List<CourseDTO> GetCourses()
      {
         var courses = new List<CourseDTO>();

         foreach (var item in GetCourses())
         {
            var c = CourseFactory.Create();
         }

         return courses;
      }

      public bool InsertStudent(StudentDTO)
      {
         var s = GetStudents().FirstOrDefault(s => s.Id == student.StudentId);

         var stu = new StudentDAO() { FirstName = student.Name, LastName = student.LName, Gender = student.Gender, Major = student.Major, Active = student.Active };

         return InsertStudent(stu);
      }

   }
}
