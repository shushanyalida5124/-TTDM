using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDM_DAL;
using System.Data;
using System.Speech.Synthesis;

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

        //缺勤
        public void Attentent()
        {
            string sql = string.Format("update t_sc set attendence_no='{0}' where stu_no='{1}'", AbsentNo + 1,StuID);
            this.AbsentNo++;
            SQLHelp.ExcuteUpdate(sql);   
        }
        public void Report()
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Rate = -2;
            speech.Speak(this.StuName);
        }
    }
}
