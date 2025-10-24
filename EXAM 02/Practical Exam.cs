using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_02
{
    internal class Practical_Exam : Exam
    {
        public Practical_Exam(int time, int numofque) : base(time, numofque) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            for (int i = 0; i < Questions.Length; i++)
            {
                Question ques = Questions[i];
                Console.WriteLine(ques.ToString());
                ques.DisQues();
                Console.Write("Enter your answer (number): ");
                int answerId = int.Parse(Console.ReadLine());

                Console.WriteLine("Correct Answer: " + ques.RightAnswer.AnswerText);
            }

        }
    }
}
