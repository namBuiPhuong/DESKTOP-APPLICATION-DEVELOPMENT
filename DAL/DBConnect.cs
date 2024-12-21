using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        public static SqlConnection Connect()
        {
            string Cnt = @"Data Source=DESKTOP-DUUE3UH\ZRPPROACE;Initial Catalog=QLCC;Integrated Security=True;Encrypt=False";
            SqlConnection cnn = new SqlConnection(Cnt);
            return cnn;
        }
    }
}
