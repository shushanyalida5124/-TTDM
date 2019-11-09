using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TTDM_DAL
{
    public class SQLHelp
    {
        public static string strConnectionstr;
        public static DataTable ExcuteQurry(string sql)
        {
            try
            {
                DataTable table = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sql, strConnectionstr);
                sda.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                string strMsg = ex.Message;
                return null;
            }
        }

        public static int ExcuteUpdate(string sql)
        {
            int i = 0;

            try
            {
                SqlConnection conn = new SqlConnection(strConnectionstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i;
            }
            catch (Exception ex)
            {
                string strMsg = ex.Message;
                return 0;
            }
        }
    }
}
