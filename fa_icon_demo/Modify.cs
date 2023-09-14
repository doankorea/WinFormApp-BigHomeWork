using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace fa_icon_demo
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlDataReader dataReader;
        public List<Account> Accounts(string query)
        {
            List <Account> accounts = new List<Account>();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader.GetString(0), dataReader.GetString(1)));
                }
                conn.Close();
            }

            return accounts;
            }
        //Signup account
        public void Command(string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();// execute the query
                conn.Close();
            }
        }
    }
}
