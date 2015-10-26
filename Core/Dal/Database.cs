using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dal
{
    public class Database
    {
        string connectionString = "";
        SqlConnection con;

        public Database()
        {

            connectionString = "Data Source = adminpc;Initial Catalog = LoginDemo; Integrated Security= SSPI;";
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int execute(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteNonQuery();
        }
        public int execute(String query, List<SqlParameter> atrs)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            if(atrs.Count != 0)
            {
                foreach(SqlParameter atr in atrs)
                {
                    cmd.Parameters.Add(atr);
                }
            }

            return cmd.ExecuteNonQuery();
        }

        public SqlDataReader query(String query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader();
        }
        public SqlDataReader query(String query, List<SqlParameter> atrs) 
        {
            SqlCommand cmd = new SqlCommand(query, con);
            if (atrs.Count != 0)
            {
                foreach (SqlParameter atr in atrs)
                {
                    cmd.Parameters.Add(atr);
                }
            }
            return cmd.ExecuteReader();
        }

        public void Disconnect()
        {
            con.Close();
        }
    }
}
