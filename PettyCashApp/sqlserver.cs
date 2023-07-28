using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PettyCashApp
{
    class sqlserver
    {
        public SqlConnection GetConn()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "Data Source=DESKTOP-DCTCEH4\\SQLEXPRESS;Initial Catalog=smkn4;Integrated Security=True";
            return Con;
        }
    }
}
