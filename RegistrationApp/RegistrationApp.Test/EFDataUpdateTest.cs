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
      private Student LocalStudentUpdate;

      public bool EFDataUpdateTest()
      {
         LocalStudentUpdate = new Student() { FirstName = "TestGender" };

         return true;
      }

      //[Fact]
      //public void Test_InsertGender()
      //{
      //   var data = new EFData();

      //   var actual = data.UpdateStudent(LocalStudentUpdate);

      //   Assert.True(actual);
      //}
   }
}
