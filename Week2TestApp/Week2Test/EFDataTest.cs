using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Week2Test
{
   public partial class EFData
   {
      [Fact]
      public void Test_InsertProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.AddProject(0, 1, 0, false);
         }
      }

      [Fact]
      public void Test_UpdateProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.UpdateProject(1, 0, 0, true, false, 6);
         }
      }

      [Fact]
      public void Test_DeleteProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.DeleteProject(2);
         }
      }

      [Fact]
      public void Test_ChangeCompletionProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.MarkCompleteIncomplete(false, 2);
         }
      }

      [Fact]
      public void Test_GetCompleteIncomplete()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.GetCompletedIncompleted(true);
         }
      }

      [Fact]
      public void Test_GetList()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.GetAll();
         }
      }
   }
}
