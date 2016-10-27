using MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
   public partial class AdoData
   {
      public bool UpdateGender(Gender gender)
      {
         var query = "update Monster.Gender set Name = @name, Active = @active where GenderId = @id";

         var Name = new SqlParameter("name", gender.Name);
         var Active = new SqlParameter("active", gender.Active ? 1 : 0);
         var Id = new SqlParameter("id", gender.GenderId);
         int result;

         using (var connection = new SqlConnection(connectionString))
         {
            var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddRange(new SqlParameter[] { Name, Active, Id });
            result = cmd.ExecuteNonQuery();
         }

         return result >= 0;
      }
   }
}
