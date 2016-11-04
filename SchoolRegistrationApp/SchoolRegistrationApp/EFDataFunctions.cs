using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrationApp
{
   public partial class EFData
   {
      #region CalledProcedures
      public void Run_AddStudent(string Name, string LName, int Gen, string Field)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var NewStudent = Reg.AddStudent(Name, LName, Gen, Field);
         }
      }

      public void Run_AddProfessor(string Dept, string Name, string LName)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var NewProfessor = Reg.AddProfessors(Dept, Name, LName);
         }
      }

      public void Run_AddCourse(string Name, int Credits, int Cap, string Dept, int Duration, TimeSpan StartTime1, TimeSpan StartTime2, TimeSpan StartTime3)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var NewCourse = Reg.AddCourse(Name, Credits, Cap, Dept, Duration, StartTime1, StartTime2, StartTime3);
         }
      }

      public void Run_AddProfessorSchedule(int Id)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var ProfessorSchedule = Reg.AddProfessorSchedule(Id);
         }
      }

      public void Run_AddStudentSchedule(int Id)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var StudentSchedule = Reg.AddStudentSchedule(Id);
         }
      }

      public void Run_AssignProfessorSchedule(int SId, int PId, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var AssignProfessorSchedule = Reg.AssignProfessorToSchedule(SId, PId, On);
         }
      }

      public void Run_AssignStudentSchedule(int SId, int StuId, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var AssignStudentSchedule = Reg.AssignStudentToSchedule(SId, StuId, On);
         }
      }

      public void Run_DeleteCourse(int Id)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveCourse = Reg.DeleteCourse(Id);
         }
      }

      public void Run_DeleteProfessor(int Id)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveProfessor = Reg.DeleteProfessor(Id);
         }
      }

      public void Run_DeleteStudent(int Id)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveStudent = Reg.DeleteStudent(Id);
         }
      }

      public void Run_DeleteSchedule(int Id)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var RemoveSchedule = Reg.DeleteSchedule(Id);
         }
      }

      public void Run_GetActiveInactiveCourses(bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var GetCourses = Reg.GetActiveInactiveCourses(On);
         }
      }

      public void Run_GetAllActiveInactiveStudents(bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var GetStudents = Reg.GetAllActiveInactiveStudents(On);
         }
      }

      public void Run_GetAllActiveInactiveProfessors(bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var GetProfessors = Reg.GetAllActiveInactiveProfessors(On);
         }
      }

      public void Run_UpdateCapacity(int Id, int NewCap)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourseCapacity = Reg.UpdateCapacity(Id, NewCap);
         }
      }

      public void Run_UpdateCourse(string Name, int Id, int CredHrs, int Cap, string Dept, int Duration, TimeSpan Class1, TimeSpan Class2, TimeSpan Class3, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse = Reg.UpdateCourse(Name, Id, CredHrs, Cap, Dept, Duration, Class1, Class2, Class3, On);
         }
      }

      public void Run_UpdateProfessor(int Id, string Dept, string Name, string LName, int Gen, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateProfessor = Reg.UpdateProfessor(Id, Dept, Name, LName, Gen, On);
         }
      }

      public void Run_UpdateStudent(int Id, string Name, string LName, int Gen, string Field, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateStudent = Reg.UpdateStudent(Id, Name, LName, Gen, Field, On);
         }
      }

      public void Run_UpdateCourse1(int SId, int CId, TimeSpan StartTime, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse1 = Reg.UpdateCourse1ToSchedule(SId, CId, StartTime, On);
         }
      }

      public void Run_UpdateCourse2(int SId, int CId, TimeSpan StartTime, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse2 = Reg.UpdateCourse2ToSchedule(SId, CId, StartTime, On);
         }
      }

      public void Run_UpdateCourse3(int SId, int CId, TimeSpan StartTime, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse3 = Reg.UpdateCourse3ToSchedule(SId, CId, StartTime, On);
         }
      }

      public void Run_UpdateCourse4(int SId, int CId, TimeSpan StartTime, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse4 = Reg.UpdateCourse4ToSchedule(SId, CId, StartTime, On);
         }
      }

      public void Run_UpdateCourse5(int SId, int CId, TimeSpan StartTime, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse5 = Reg.UpdateCourse5ToSchedule(SId, CId, StartTime, On);
         }
      }

      public void Run_UpdateCourse6(int SId, int CId, TimeSpan StartTime, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse6 = Reg.UpdateCourse6ToSchedule(SId, CId, StartTime, On);
         }
      }

      public void Run_UpdateCourse7(int SId, int CId, TimeSpan StartTime, bool On)
      {
         using (var Reg = new RegistrationDBEntities())
         {
            var UpdateCourse7 = Reg.UpdateCourse7ToSchedule(SId, CId, StartTime, On);
         }
      }
      #endregion


   }
}
