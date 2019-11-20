using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TTDM_DAL;

namespace TTDM_BLL
{
    public class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        private string password;
        public string[] coursesNo = new string[8];

        public  string Password
        {
            get { return password; }
        }

        public User()
        {

        }
        public User(string id,string pwd)
        {
            ID = id;
            password = pwd;
        }

        //用户有效性判断
        public bool IsUserValid()
        {
            string sql = string.Format("select * From t_user where user_id='{0}' and user_psd='{1}'",
                this.ID,this.password);
            DataTable table = SQLHelp.ExcuteQurry(sql);
            if (table==null)
            {
                return false;
            }

            if (table.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //点名
        public Student Roll()
        {
            Student stu = new Student(); 
            string sql = string.Format("select * from t_student join  t_sc on t_student.stu_no = t_sc.stu_no join t_course on t_sc.course_no = t_course.course_no join t_user on t_course.user_id = t_user.user_id where t_user.user_id = '{0}'",this.ID);
            DataTable dt = SQLHelp.ExcuteQurry(sql);
            int i = dt.Rows.Count;
            Random rd = new Random();
            DataRow stuRow = dt.Rows[rd.Next(0,i)];
            stu.StuName= stuRow.Field<string>("stu_name");
            stu.StuID = stuRow.Field<string>("stu_no");
            stu.AbsentNo = int.Parse(stuRow.Field<string>("attendence_no"));
            return stu;
        }

        //将只有id的user补充完整
        public void Add()
        {
            string sql = string.Format("select * from t_user where user_id='{0}'",this.ID);
            DataTable dt = SQLHelp.ExcuteQurry(sql);
            this.Name = dt.Rows[0].Field<string>("user_name");
            this.password = dt.Rows[0].Field<string>("user_psd");
            sql = string.Format("select * from t_student join  t_sc on t_student.stu_no = t_sc.stu_no join t_course on t_sc.course_no = t_course.course_no join t_user on t_course.user_id = t_user.user_id where t_user.user_id = '{0}'", this.ID);
            dt = SQLHelp.ExcuteQurry(sql);
            int n = dt.Rows.Count;
            if (n>0)
            {
                string courseNo;
                bool flag;
                int i = 0;
                foreach (DataRow item in dt.Rows)
                {
                    courseNo = item.Field<string>("course_no");
                    foreach (var no in coursesNo)
                    {
                        if (no==courseNo)
                        {
                            flag = false;
                        }
                        else
                        {
                            flag = false;
                        }
                        if (flag)
                        {
                            coursesNo[i] = courseNo;
                            i++;
                        }
                    }
                }
            }

        }
        //查询学生
        public DataTable Qurry(string sql)
        {
            return SQLHelp.ExcuteQurry(sql);
        }
        public void Update(string sql)
        {
            SQLHelp.ExcuteUpdate(sql);
        }
        public void UpdatePwd(string pwd)
        {
            string sql = string.Format("update t_user set user_psd='{0}' where " +
                "user_id='{1}'",pwd,this.ID);
            SQLHelp.ExcuteUpdate(sql);
        }

        //添加课程
        public int AddCourse(string courseName,string courseNO)
        {
            string sql = string.Format("insert into t_course values('{0}','{1}','{2}')",courseNO,this.ID,courseName);
            return SQLHelp.ExcuteUpdate(sql);
        }
    }
}
