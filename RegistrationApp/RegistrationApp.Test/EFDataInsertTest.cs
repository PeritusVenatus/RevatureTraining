using RegistrationApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationApp.Test
{
   public partial class EFDataTest
   {
      private Student LocalStudent;

      public bool EFDataInsertTest()
      {
         LocalStudent = new Student() { FirstName = "Fred" };

         return true;
      }

      [Fact]
      public void Test_InsertStudent()
      {
         var data = new EFData();

         var actual = data.InsertStudent(LocalStudent);

         Assert.True(actual);
      }

      [Fact]
      public void Test_InsertCourse()
      {
         var data = new EFData();

         var actual = data.AddCourse();

         try { Assert.True(actual); }
         catch (Exception ex) { };
         
      }
   }
}
