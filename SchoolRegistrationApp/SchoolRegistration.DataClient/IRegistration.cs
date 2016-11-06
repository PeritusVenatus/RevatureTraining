using SchoolRegistration.DataClient.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SchoolRegistration.DataClient
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegistration" in both code and config file together.
   [ServiceContract]
   public interface IRegistration
   {
      [OperationContract]
      List<StudentDAO> GetStudents();

      [OperationContract]
      List<ProfessorDAO> GetProfessors();

      [OperationContract]
      List<CourseDAO> GetCourses();

      [OperationContract]
      List<ScheduleDAO> GetSchedules();
   }
}
