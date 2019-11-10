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
            InitializeComponent();
        }

        private void BtnDM_Click(object sender, EventArgs e)
        {
            Student luckyStu = user.Roll();
            label1.Text = luckyStu.StuName;
            label2.Text = luckyStu.StuID;
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {
            user.Add();
            label3.Text = "你好" + user.Name;
        }
    }
}
