using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_02
{
    internal class Final_Exam : Exam
    {
        public Final_Exam(int time, int numofque) : base(time, numofque)
        {

        }

        public override void ShowExam()
        {
            Console.WriteLine(" Final Exam ");
            int totalMark = 0, studentMark = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                Question ques = Questions[i];
                Console.WriteLine(ques.ToString());
                ques.DisQues();
                Console.Write("Enter your answer (number): ");
                int answerId = int.Parse(Console.ReadLine());

                totalMark += ques.Mark;
                if (ques.RightAnswer.AnswerId == answerId)
                    studentMark += ques.Mark;
                Console.WriteLine("Grade is : " + studentMark + " from " + totalMark);

            }
        }
    }
    
}
