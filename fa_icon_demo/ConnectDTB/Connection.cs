using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Markup;

namespace fa_icon_demo
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=EL\DOANKOREA;Initial Catalog=DTB_Skins;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
