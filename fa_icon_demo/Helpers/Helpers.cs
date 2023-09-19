using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fa_icon_demo.CustomControls;
using System.IO;
using System.Drawing;
using fa_icon_demo.NewFolder1;

namespace fa_icon_demo.DbHelper
{

    public class Helpers
    {
        Modify Modify = new Modify();
        public Helpers()
        {
        }
        public string getButtons(string query, FlowLayoutPanel panel)
        {
            String ret = "";

            string images_and_storage_id, name;
            decimal price;

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    images_and_storage_id = reader.GetString(3).ToString();
                    name = reader.GetString(0).ToString();
                    price = (decimal)reader[1];         
                    string skinprice = "$"+ price.ToString();
                    byte[] b = (byte[])reader["image"];

                    btnItem btnItem = new btnItem();
                    if (b != null && b.Length > 0)
                    {
                        btnItem.itemImage = ByteArrayToImage(b);
                    }

                    btnItem.itemName = name;
                    btnItem.itemPrice = skinprice;
                    Image ByteArrayToImage(byte[] c)
                    {
                        MemoryStream m = new MemoryStream(c);
                        return Image.FromStream(m);

                    }
                    if (!string.IsNullOrEmpty(name))
                    {
                        panel.Controls.Add(btnItem);
                    }
                    

                    ret = "Data Fetch Successfully.. :";

                }

                conn.Close();
            }



            return ret;
        }
    }
}

