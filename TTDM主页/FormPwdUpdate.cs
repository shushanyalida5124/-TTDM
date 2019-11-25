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
    public partial class FormPwdUpdate : Form
    {
        User user;
        public FormPwdUpdate(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string strOldPwd = txtOldPwd.Text.Trim(), strNewPwd1 = txtNewPwd1.Text.Trim(),
                strNewPwd2 = txtNewPwd2.Text.Trim();
            if (strOldPwd.Length==0)
            {
                MessageBox.Show("请输入旧密码");
                return;
            }
            if (strNewPwd1.Length==0)
            {
                MessageBox.Show("请输入新密码");
                return;
            }
            if (strNewPwd1!=strNewPwd2)
            {
                MessageBox.Show("两次密码不一致");
                return;
            }
            User u = new User(user.ID,strOldPwd);
            if (u.IsUserValid() && strNewPwd1 == strNewPwd2)
            {
                user.UpdatePwd(strNewPwd1);
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误");
            }
        }

        private void FormPwdUpdate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
