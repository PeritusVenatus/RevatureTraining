using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess
{
   public partial class EFData
   {
      //Remove a student from DB, NEEDS TO BE TESTED
      public bool RemoveStudent(Student student)
      {
         db.Students.Remove(student);
         return db.SaveChanges() > 0;
      }

      public bool RemoveStudentSchedule(StudentSchedule schedule)
      {
         db.StudentSchedules.Remove(schedule);
         return db.SaveChanges() > 0;
      }

      public bool RemoveProfessor(Professor professor)
      {
         db.Professors.Remove(professor);
         return db.SaveChanges() > 0;
      }

      public bool RemoveProfessorSchedule(ProfessorSchedule schedule)
      {
         db.ProfessorSchedules.Remove(schedule);
         return db.SaveChanges() > 0;
      }

      public bool RemoveCourse(Cours course)
      {
         db.Courses.Remove(course);
         return db.SaveChanges() > 0;
      }
   }
}
