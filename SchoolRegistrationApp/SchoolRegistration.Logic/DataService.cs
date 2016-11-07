using SchoolRegistration.DataClient;
using SchoolRegistration.DataClient.DAOs;
using SchoolRegistration.Logic.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistration.Logic
{
   public class DataService
   {
      private Registration RT = new Registration();
      private StudentFactory<StudentDTO> studentFactory = new StudentFactory<StudentDTO>();
      private ProfessorFactory<ProfessorDTO> professorFactory = new ProfessorFactory<ProfessorDTO>();
      private CourseFactory<CourseDTO> courseFactory = new CourseFactory<CourseDTO>();
     //private ScheduleFactory<ScheduleDTO> scheduleFactory = new ScheduleFactory<ScheduleDTO>();

      public List<StudentDTO> GetStudents()
      {
         var students = new List<StudentDTO>();

         foreach (var item in RT.GetStudents())
         {
           var s = studentFactory.Create();

            s.FirstName = item.FirstName;

            students.Add(s);
         }

         return students;
      }

      public List<ProfessorDTO> GetProfessors()
      {
         var professors = new List<ProfessorDTO>();

         foreach (var item in RT.GetProfessors())
         {
            var p = professorFactory.Create();

            p.FirstName = item.FirstName;

            professors.Add(p);
         }

         return professors;
      }

      public List<CourseDTO> GetCourses()
      {
         var courses = new List<CourseDTO>();

         foreach (var item in RT.GetCourses())
         {
            var c = courseFactory.Create();

            c.CourseName = item.CourseName;

            courses.Add(c);
         }

         return courses;
      }

      //public bool InsertStudent(StudentDTO)
      //{
      //   var s = GetStudents().FirstOrDefault(s => s.Id == student.StudentId);

      //   var stu = new StudentDAO() { FirstName = student.Name, Las tName= student.LName, Gender = student.Gender, Major = student.Major, Active = student.Active };

      //   return InsertStudent(stu);
      //} 

   }
}
