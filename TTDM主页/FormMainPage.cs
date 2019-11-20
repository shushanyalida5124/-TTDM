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
    public partial class FormMainPage : Form
    {
        User user;
        public FormMainPage(User user)
        {
            this.user = user;
            this.user.Add();
            
            InitializeComponent();
        }

        private void BtnDM_Click(object sender, EventArgs e)
        {
            Student luckyStu = user.Roll();
            label1.Text = luckyStu.StuName;
            label2.Text = luckyStu.StuID;
            luckyStu.Report();
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
    }
}
