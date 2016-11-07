using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SchoolRegistrationApp
{
   public class EFDataTests
   {
      private RegistrationDBEntities db = new RegistrationDBEntities();

      #region TestProcedures

      [Fact]
      public void Test_AddStudent()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var NewStudent = Reg.AddStudent("Test", "Test", 0, "Test");
         }
      }

      [Fact]
      public void Test_AddProfessor()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var NewProfessor = Reg.AddProfessors("Test", "Test", "Test");
         }
      }

      [Fact]
      public void Test_AddCourse()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var NewCourse = Reg.AddCourse("Test", 0, 0, "Test", 0, new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0));
         }
      }

      [Fact]
      public void Test_AddProfessorSchedule()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var ProfessorSchedule = Reg.AddProfessorSchedule(1);
         }
      }

      [Fact]
      public void Test_AddStudentSchedule()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var StudentSchedule = Reg.AddStudentSchedule(1);
         }
      }

      [Fact]
      public void Test_AssignProfessorSchedule()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var AssignProfessorSchedule = Reg.AssignProfessorToSchedule(1, 1, true);
         }
      }

      [Fact]
      public void Test_AssignStudentSchedule()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var AssignStudentSchedule = Reg.AssignStudentToSchedule(1, 1, true);
         }
      }

      [Fact]
      public void Test_DeleteCourse()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveCourse = Reg.DeleteCourse(5);
         }
      }

      [Fact]
      public void Test_DeleteProfessor()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveProfessor = Reg.DeleteProfessor(6);
         }
      }

      [Fact]
      public void Test_DeleteStudent()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveStudent = Reg.DeleteStudent(1);
         }
      }

      [Fact]
      public void Test_DeleteSchedule()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveSchedule = Reg.DeleteSchedule(5);
         }
      }

      [Fact]
      public void Test_GetActiveInactiveCourses()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var GetCourses = Reg.GetActiveInactiveCourses(true);
         }
      }

      [Fact]
      public void Test_GetAllActiveInactiveStudents()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var GetStudents = Reg.GetAllActiveInactiveStudents(true);
         }
      }

      [Fact]
      public void Test_GetAllActiveInactiveProfessors()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var GetProfessors = Reg.GetAllActiveInactiveProfessors(true);
         }
      }

      [Fact]
      public void Test_UpdateCapacity()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourseCapacity = Reg.UpdateCapacity(5, 30);
         }
      }

      [Fact]
      public void Test_UpdateCourse()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse = Reg.UpdateCourse("Test", 4, 0, 0, "Test", 0, new TimeSpan(0,0,0), new TimeSpan(0,0,0), new TimeSpan(0,0,0), true);
         }
      }

      [Fact]
      public void Test_UpdateProfessor()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateProfessor = Reg.UpdateProfessor(1, "Test", "Test", "Test", 0, true);
         }
      }

      [Fact]
      public void Test_UpdateStudent()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateStudent = Reg.UpdateStudent(1, "Test", "Test", 0, "Test", true);
         }
      }

      [Fact]
      public void Test_UpdateCourse1()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse1 = Reg.UpdateCourse1ToSchedule(1, 1, new TimeSpan(0,0,0), true);
         }
      }

      [Fact]
      public void Test_UpdateCourse2()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse2 = Reg.UpdateCourse2ToSchedule(1, 1, new TimeSpan(0, 0, 0), true);
         }
      }

      [Fact]
      public void Test_UpdateCourse3()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse3 = Reg.UpdateCourse3ToSchedule(1, 1, new TimeSpan(0, 0, 0), true);
         }
      }

      [Fact]
      public void Test_UpdateCourse4()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse4 = Reg.UpdateCourse4ToSchedule(1, 1, new TimeSpan(0, 0, 0), true);
         }
      }

      [Fact]
      public void Test_UpdateCourse5()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse5 = Reg.UpdateCourse5ToSchedule(1, 1, new TimeSpan(0, 0, 0), true);
         }
      }

      [Fact]
      public void Test_UpdateCourse6()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse6 = Reg.UpdateCourse6ToSchedule(1, 1, new TimeSpan(0, 0, 0), true);
         }
      }

      [Fact]
      public void Test_UpdateCourse7()
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse7 = Reg.UpdateCourse7ToSchedule(1, 1, new TimeSpan(0, 0, 0), true);
         }
      }
      #endregion
   }
}
