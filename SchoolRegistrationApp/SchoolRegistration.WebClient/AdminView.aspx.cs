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
      protected void Page_Load(object sender, EventArgs e)
      {
         GetStudents();
         GetProfessors();
         GetCourses();
      }

      private void GetStudents()
      {
         var data = new DataService();
         StudentList.Items.Clear();

         foreach (var item in data)
         {
            StudentList.Items.Add(item.name);
         }
      }

      private void GetProfessors()
      {
         var data = new DataService();
         ProfessorList.Items.Clear();

         foreach (var item in data)
         {
            ProfessorList.Items.Add(item.name);
         }
      }

      private void GetCourses()
      {
         var data = new DataService();
         CourseList.Items.Clear();

         foreach (var item in data)
         {
            CourseList.Items.Add(item.name);
         }
      }
   }
}