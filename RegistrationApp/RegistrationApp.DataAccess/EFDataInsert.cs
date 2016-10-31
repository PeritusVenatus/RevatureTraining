using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess
{
   public partial class EFData
   {
      //Add a student to DB, NEEDS TO BE TESTED
      public bool InsertStudent(Student student)
      {
         db.Students.Add(student);
         return db.SaveChanges() > 0;
      }

      public bool InsertStudentSchedule(StudentSchedule schedule)
      {
         db.StudentSchedules.Add(schedule);
         return db.SaveChanges() > 0;
      }

      public bool InsertProfessor(Professor professor)
      {
         db.Professors.Add(professor);
         return db.SaveChanges() > 0;
      }

      public bool InsertProfessorSchedule(ProfessorSchedule schedule)
      {
         db.ProfessorSchedules.Add(schedule);
         return db.SaveChanges() > 0;
      }

      public bool InsertCourse(Cours course)
      {
         db.Courses.Add(course);
         return db.SaveChanges() > 0;
      }

      public bool AddCourse()
      {

         using (var context = new RegistrationDBEntities1())
         {
            var courses = context.AddCourse(1, 36, "Mathematics");

            return db.SaveChanges() > 0;
         }
      }
   }
}
