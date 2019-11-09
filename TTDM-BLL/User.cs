using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TTDM_DAL;

namespace TTDM_BLL
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private string password;
        public User(int id,string pwd)
        {
            ID = id;
            password = pwd;
        }

        //用户有效性判断
        public bool IsUserValid()
        {
            string sql = string.Format("select * From t_user where user_id='{0}' and user_psw='{1}'",
                this.ID,this.password);
            DataTable table = SQLHelp.ExcuteQurry(sql);

            if (table.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
