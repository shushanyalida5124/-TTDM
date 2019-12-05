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
using System.Collections.Generic;
using System.Collections;
using System.Threading;


namespace TTDM主页
{
    public partial class FormMainPage : Form
    {
        User user;
        List<Student> rolledStudents = new List<Student>(); 
        public FormMainPage(User user)
        {
            this.user = user;
            this.user.Add();
            
            InitializeComponent();
        }

        private void BtnDM_Click(object sender, EventArgs e)
        {
            Student luckyStu;
            bool isRolled;
            int i=0;
            do
            {
                luckyStu = user.Roll();
                isRolled = false;
                i++;
                foreach (Student stu in rolledStudents)
                    {
                        if (rolledStudents.Count != 0 && stu.StuID == luckyStu.StuID)
                        {
                            isRolled = true;
                            break;
                        }
                    }
                
               
            }
            while (isRolled&&i<200);
            if (i>=200)
            {
                MessageBox.Show("已点完所有学生");
                return;
            }

            rolledStudents.Add(luckyStu);
            label1.Text = luckyStu.StuName;
            label2.Text = luckyStu.StuID;
            new Thread(luckyStu.Report).Start();
            DialogResult result= MessageBox.Show("学生是否到了","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                luckyStu.Attentent();
                MessageBox.Show(string.Format("{0}同学已缺勤{1}次",luckyStu.StuName,luckyStu.AbsentNo));
            }
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {
            label3.Text = "你好," + user.Name; 
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void 考勤信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KaoQinInfo(user).ShowDialog();
        }

        private void PsdUpdate_Click(object sender, EventArgs e)
        {
            new FormPwdUpdate(user).ShowDialog();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddCourse(user).ShowDialog();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
