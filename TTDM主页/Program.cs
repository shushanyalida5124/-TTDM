using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTDM_BLL;

namespace TTDM主页
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginFrom());

            LoginFrom loginFrom = new LoginFrom();
            loginFrom.ShowDialog();

            if (loginFrom.DialogResult==DialogResult.OK)
            {
                Application.Run(new FormMainPage(loginFrom.currentUser));
            }
        }
    }
}
