using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EXAM_02
{
    internal class Exam
    {
        public int Time { get; set; }
        public int NumofQues { get; set; }
        public Question[] Questions;


        public Exam(int time, int numofque)
        {
            Time = time;
            NumofQues = numofque;
            Questions = new Question[numofque];

        }
        public virtual void ShowExam() { Console.WriteLine("-------------------"); }

    }
}
