using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class Deletion
    {
        public void Delete(object id, string procedure, string parameter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure,MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parameter, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG("Data Delete Successfully", "Success.....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
        }
    }
}
