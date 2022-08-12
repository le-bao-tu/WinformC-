using System.Data.SqlClient;

namespace BTL_QLSV_WINFORM.DataAccessConnect
{
    public class SQLServerConnection
    {
        private static string strcon = "server=localhost;database=QLSV_WINFORM;uid=sa;pwd=123456;MultipleActiveResultSets=true";

        public static string StringConnection
        {
            get
            {
                return strcon;
            }
        }

        public static SqlConnection Connection
        {
            get
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                return con;
            }
        }
    }
}