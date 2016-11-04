using MonsterWeb.Logic;
using MonsterWeb.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonsterWeb.Client
{
   public partial class EntryForm : System.Web.UI.Page
   {
      private DataService data = new DataService();
      private FactoryThing<GenderDTO> genderFactory = new FactoryThing<GenderDTO>();
      protected void Page_Load(object sender, EventArgs e)
      {
         if(!IsPostBack)
         {
            LoadGenders();
         }
      }

      private void LoadGenders()
      {
         MonsterGender_List.Items.Clear();

         foreach (var item in data.GetGenders())
         {
            MonsterGender_List.Items.Add(new ListItem() { Text = item.Name, Value = item.AppId.ToString() });

         }
         
      }

      private bool InsertValidated()
      {
         if (string.IsNullOrWhiteSpace(MonsterName_Text.Text) && string.IsNullOrWhiteSpace(MonsterGender_List.SelectedItem.Value))
         {
            return false;
         }

         var gender = genderFactory.Create();
         gender.AppId = int.Parse(MonsterGender_List.SelectedItem.Value);
         gender.Name = MonsterName_Text.Text;


         return data.InsertMonster(gender);
      }

      protected void MonsterSubmit_Click(object sender, EventArgs e)
      {
         if (InsertValidated())
         {
            MonsterName_Text.Text = string.Empty;
            MonsterGender_List.SelectedIndex = 0;
         }
      }
   }
}
