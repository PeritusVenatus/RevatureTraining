using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DataAccess
{
   public partial class EFData
   {
      public bool UpdateStudent(Student student, EntityState state)
      {
         var entry = db.Entry<Student>(student);

         entry.State = state;
         return db.SaveChanges() > 0;
      }

      public bool UpdateStudentSchedule(StudentSchedule schedule, EntityState state)
      {
         var entry = db.Entry<StudentSchedule>(schedule);

         entry.State = state;
         return db.SaveChanges() > 0;
      }

      public bool UpdateProfessor(Professor professor, EntityState state)
      {
         var entry = db.Entry<Professor>(professor);

         entry.State = state;
         return db.SaveChanges() > 0;
      }

      public bool UpdateProfessorSchedule(ProfessorSchedule schedule, EntityState state)
      {
         var entry = db.Entry<ProfessorSchedule>(schedule);

         entry.State = state;
         return db.SaveChanges() > 0;
      }

      public bool UpdateCourse(Cours course, EntityState state)
      {
         var entry = db.Entry<Cours>(course);

         entry.State = state;
         return db.SaveChanges() > 0;
      }

   }
}
