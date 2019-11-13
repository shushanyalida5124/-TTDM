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
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User testUser = new User();
            testUser.ID = "0001";
            testUser.Add();
            label3.Text = "测试账号：" + testUser.ID;
            label4.Text = "测试账号密码：" + testUser.Password;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        public User currentUser = new User();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = textUserName.Text.Trim();
            string strPassWord = textPwd.Text.Trim();
            //检查用户有效性
            if (strUserName!=null&&strUserName.Length==0)
            {
                MessageBox.Show("请输入用户名");
                textUserName.Focus();
                return;
            }
            if (strPassWord.Length==0)
            {
                MessageBox.Show("请输入密码");
                textPwd.Focus();
                return;
            }
            ;
            currentUser = new User(strUserName, strPassWord);
            if (currentUser.IsUserValid())
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请核对后输入");
                textUserName.Focus();
            }
        }
    }
}
