using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDM_DAL;
using System.Data;

namespace TTDM_BLL
{
    public class Student
    {
        public string StuID { get; set; }
        public string StuName { get; set; }
        public int AbsentNo { get; set; }

        public Student()
        {

        }
        public Student(string id,string name)
        {
            StuID = id;
            StuName = name;
        }

        
    }
}
