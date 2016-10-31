using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
   public partial class EFData
   {
      private Week2TestDBEntities db = new Week2TestDBEntities();

      public void Run_InsertProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.AddProject(0, 1, 0, false);
         }
      }

      public void Run_UpdateProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.UpdateProject(1, 0, 0, true, false, 6);
         }
      }

      public void Run_DeleteProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.DeleteProject(2);
         }
      }

      public void Run_ChangeCompletionProject()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.MarkCompleteIncomplete(false, 2);
         }
      }

      public void Run_GetCompleteIncomplete()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.GetCompletedIncompleted(true);
         }
      }

      public void Run_GetList()
      {
         using (var Wk2 = new Week2TestDBEntities())
         {
            //Execute stored procedure as a function
            var courseList = Wk2.GetAll();
         }
      }
   }
}
