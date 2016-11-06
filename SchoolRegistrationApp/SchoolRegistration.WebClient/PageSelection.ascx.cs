using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolRegistration.WebClient
{
   public partial class PageSelection : System.Web.UI.UserControl
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            Message.Text = string.Empty;
         }
      }

      protected void Admin_Click(object sender, EventArgs e)
      {
         Response.Redirect("~/AdminView.aspx");
      }

      protected void Professor_Click(object sender, EventArgs e)
      {
         Response.Redirect("~/ProfessorView.aspx");
      }

      protected void Student_Click(object sender, EventArgs e)
      {
         Response.Redirect("~/StudentView.aspx");
      }
   }
}