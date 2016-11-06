using SchoolRegistration.DataClient.DAOs;
using SchoolRegistrationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolRegistration.DataClient.Mappers
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