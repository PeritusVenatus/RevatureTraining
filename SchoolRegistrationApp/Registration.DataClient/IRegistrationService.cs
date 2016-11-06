using Registration.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Registration.DataClient
{
   [ServiceContract]
   public interface IRegistrationService
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
