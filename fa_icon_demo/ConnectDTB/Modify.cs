using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Collections;
using System.IO;

namespace fa_icon_demo
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        public DataTable DataTable(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter= new SqlDataAdapter(query,sqlConnection);
                dataAdapter.Fill(dataTable);    
                sqlConnection.Close();
            } 
            return dataTable;
        }


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
