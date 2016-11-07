using SchoolRegistration.DataClient;
using SchoolRegistration.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolRegistration.WebClient
{
   public partial class AdminView : System.Web.UI.Page
   {
      private DataService DS = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {
        GetStudents();
        GetProfessors();
        GetCourses();
      }

      private void GetStudents()
      {
         Student_List.Items.Clear();

         foreach (var item in DS.GetStudents())
         {
            Student_List.Items.Add(item.FirstName);
         }
      }

      private void GetProfessors()
      {
         Professor_List.Items.Clear();

         foreach (var item in DS.GetProfessors())
         {
            Professor_List.Items.Add(item.FirstName);
         }
      }

      private void GetCourses()
      {
         Course_List.Items.Clear();

         foreach (var item in DS.GetCourses())
         {
            Course_List.Items.Add(item.CourseName);
         }
      }
   }
}