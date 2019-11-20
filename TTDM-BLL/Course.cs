using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDM_DAL;
using System.Data;

namespace TTDM_BLL
{
    public class Course
    {
        public string Name { get; set; }
        public string No { get; set; }
        public string UserId { get; set; }

        //补全
        public void Add()
        {
            string sql = string.Format("select * from t_course where course_no='{0}'", this.No);
            DataTable dt = SQLHelp.ExcuteQurry(sql);
            this.Name = dt.Rows[0].Field<string>("course_name");
            this.UserId = dt.Rows[0].Field<string>("user_id");
        }

        //上传到数据库
        public void UpLoad()
        {
        
        }
    }
}
