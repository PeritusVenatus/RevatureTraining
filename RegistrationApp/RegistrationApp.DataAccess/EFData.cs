using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationApp.DataAccess
{
   public partial class EFData
   {
      private RegistrationDBEntities1 db = new RegistrationDBEntities1();

      public List<Student> GetStudents()
      {
         return db.Students.ToList();
      }

      public List<StudentSchedule> GetStudentsSchedules()
      {
         return db.StudentSchedules.ToList();
      }

      public List<Professor> GetProfessors()
      {
         return db.Professors.ToList();
      }

      public List<ProfessorSchedule> GetProfessorsSchedules()
      {
         return db.ProfessorSchedules.ToList();
      }

      [Fact]
      public List<Cours> GetCourses()
      {
         return db.Courses.ToList();
      }

      //public List<Student> GetCoursesWithStudents()
      //{
      //   return db.Courses.ToList();
      //}
     

      #region Old Code
      //public bool InsertGender(Gender gender)
      //{
      //   db.Genders.Add(gender);
      //   return db.SaveChanges() > 0;
      //}

      /// <summary>
      /// 
      /// </summary>
      /// <param name="gender"></param>
      /// <param name="state"></param>
      /// <returns></returns>

      //public bool ChangeGender(Gender gender, EntityState state)
      //{
      //   var entry = db.Entry<Gender>(gender);

      //   entry.State = state;
      //   return db.SaveChanges() > 0;
      //}
      #endregion

   }
}
