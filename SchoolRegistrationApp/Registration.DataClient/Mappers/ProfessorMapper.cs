using Registration.DataClient.Models;
using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.DataClient.Mappers
{
   public class ProfessorMapper
   {
      public static ProfessorDAO MapToProfessorDAO(Professor professor)
      {
         var p = new ProfessorDAO();

         p.ProfessorId = professor.ProfessorId;
         p.FirstName = professor.FirstName;
         p.LastName = professor.LastName;
         p.Department = professor.Department;
         p.Active = professor.Active;

         return p;
      }
   }
}
