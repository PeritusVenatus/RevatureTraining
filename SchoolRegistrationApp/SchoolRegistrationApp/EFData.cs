using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrationApp
{
   public partial class EFData
   {
      private RegistrationDBEntities db = new RegistrationDBEntities();

      public List<Student> GetStudents()
      {
         return db.Students.ToList();
      }

      public List<Professor> GetProfessors()
      {
         return db.Professors.ToList();
      }

      public List<Cours> GetCourses()
      {
         return db.Courses.ToList();
      }

      public List<Schedule> GetSchedules()
      {
         return db.Schedules.ToList();
      }
   }
}
