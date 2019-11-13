using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTDM_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TTDM_BLL.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void AddCourseTest()
        {
            User user = new User("0001","000000");
            user.AddCourse("数学","0002");
            string sql = string.Format("select * from t_course where couse_no='0001' " +
                "and course_name='数学' and user_id='{0}' ",user.ID);
             
        }
    }
}