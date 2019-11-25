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
using System.Data;

namespace TTDM主页
{
    public partial class FormAddCourse : Form
    {
        User user;
        public FormAddCourse(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            string strCName = txtCName.Text.Trim(), strCNo = txtCNo.Text.Trim();
            DataTable dt = user.Qurry(string.Format("select * from t_course where course_no='{0}'",strCNo));
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("课程号已存在");
                return;
            }
            DialogResult result= MessageBox.Show(string.Format("确认添加课程{0}",strCName),"提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result==DialogResult.OK)
            {
                int i= user.AddCourse(strCName,strCNo);
                if (i>0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
               
            }
        }

        private void SkinBtnAdd_Click(object sender, EventArgs e)
        {
            string strCName = txtCName.Text.Trim(), strCNo = txtCNo.Text.Trim();
            DataTable dt = user.Qurry(string.Format("select * from t_course where course_no='{0}'", strCNo));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("课程号已存在");
                return;
            }
            DialogResult result = MessageBox.Show(string.Format("确认添加课程{0}", strCName), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int i = user.AddCourse(strCName, strCNo);
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }

            }
        }
    }
}
