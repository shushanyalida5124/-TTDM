using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTDM_BLL;
namespace TTDM主页
{
    public partial class KaoQinInfo : Form
    {
        User user;
        DataTable dt;
        public KaoQinInfo(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void CtnQurry_Click(object sender, EventArgs e)
        //{
        //    string sql;
        //    string strName = txtName.Text.Trim(), strNo = txtStuNo.Text.Trim();
        //    if (strName.Length == 0 && strNo.Length != 0)
        //    {
        //        sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
        //       "t_student.stu_no=t_sc.stu_no join t_course on" +
        //       " t_sc.course_no=t_course.course_no where " +
        //       "t_student.stu_no='{0}' and user_id='{1}'", strNo,user.ID);
        //    }
        //    else if (strName.Length != 0 && strNo.Length == 0)
        //    {
        //        sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
        //      "t_student.stu_no=t_sc.stu_no join t_course on" +
        //      " t_sc.course_no=t_course.course_no where " +
        //      "t_student.stu_name='{0}' and user_id='{1}'", strName, user.ID);
        //    }
        //    else if (strName.Length != 0 && strNo.Length != 0)
        //    {
        //        sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
        //      "t_student.stu_no=t_sc.stu_no join t_course on" +
        //      " t_sc.course_no=t_course.course_no where " +
        //      "t_student.stu_no='{0}' and stu_name='{1}' and user_id='{1}'", strNo, strName, user.ID);
        //    }
        //    else
        //    {
        //        sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
        //      "t_student.stu_no=t_sc.stu_no join t_course on" +
        //      " t_sc.course_no=t_course.course_no where user_id='{0}'",user.ID);
        //    }
        //     dt = user.Qurry(sql);
        //    int n = dt.Rows.Count;
        //    dataGridView1.Rows.Clear();
        //    if (dt==null||n==0)
        //    {
        //        MessageBox.Show("未查询到匹配学生");
        //        return;
        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        dataGridView1.Rows.Add(dt.Rows[i].Field<string>("stu_no"),
        //        dt.Rows[i].Field<string>("stu_name"), dt.Rows[i].Field<string>("class_name"),
        //        dt.Rows[i].Field<string>("course_name"),dt.Rows[i].Field<string>("attendence_no"));
        //    }
        //}

        private void KaoQinInfo_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            int n = dataGridView1.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                sql = string.Format("update t_sc set attendence_no= '{0}'  where stu_no= '{1}'",
                dataGridView1.Rows[i].Cells[4].Value,dataGridView1.Rows[i].Cells[0].Value);
                user.Update(sql);
            }
            MessageBox.Show("修改成功");
            
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
             string filename= @"考勤.txt";
            if (dt.Rows.Count==0||dt==null)
            {
                MessageBox.Show("学生信息为空");
            }
            else
            {
            User.Export(dt,filename);
            MessageBox.Show("考勤信息已导出到"+filename+",请及时备份");
            }
            
        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            string sql;
            string strName = txtName.Text.Trim(), strNo = txtStuNo.Text.Trim();
            if (strName.Length == 0 && strNo.Length != 0)
            {
                sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
               "t_student.stu_no=t_sc.stu_no join t_course on" +
               " t_sc.course_no=t_course.course_no where " +
               "t_student.stu_no='{0}' and user_id='{1}'", strNo, user.ID);
            }
            else if (strName.Length != 0 && strNo.Length == 0)
            {
                sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
              "t_student.stu_no=t_sc.stu_no join t_course on" +
              " t_sc.course_no=t_course.course_no where " +
              "t_student.stu_name='{0}' and user_id='{1}'", strName, user.ID);
            }
            else if (strName.Length != 0 && strNo.Length != 0)
            {
                sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
              "t_student.stu_no=t_sc.stu_no join t_course on" +
              " t_sc.course_no=t_course.course_no where " +
              "t_student.stu_no='{0}' and stu_name='{1}' and user_id='{2}'", strNo, strName, user.ID);
            }
            else
            {
                sql = string.Format("select t_student.stu_no,t_student.stu_name,attendence_no,class_name,t_course.course_name from t_student join t_sc on " +
              "t_student.stu_no=t_sc.stu_no join t_course on" +
              " t_sc.course_no=t_course.course_no where user_id='{0}'", user.ID);
            }
            dt = user.Qurry(sql);
            int n = dt.Rows.Count;
            dataGridView1.Rows.Clear();
            if (dt == null || n == 0)
            {
                MessageBox.Show("未查询到匹配学生");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add(dt.Rows[i].Field<string>("stu_no"),
                dt.Rows[i].Field<string>("stu_name"), dt.Rows[i].Field<string>("class_name"),
                dt.Rows[i].Field<string>("course_name"), dt.Rows[i].Field<string>("attendence_no"));
            }
        }

        private void SkinbtnUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            int n = dataGridView1.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                sql = string.Format("update t_sc set attendence_no= '{0}'  where stu_no= '{1}'",
                dataGridView1.Rows[i].Cells[4].Value, dataGridView1.Rows[i].Cells[0].Value);
                user.Update(sql);
            }
            MessageBox.Show("修改成功");
        }
    }
}
