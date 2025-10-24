using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_02
{
    internal class TrueorFalse : Question
    {
        public TrueorFalse(string? header, string? body, int markstr, bool correctAnswer) : base(header, body, markstr)
        {
            Answerlist = new Answers[2];
            Answerlist[0] = new Answers(1, "True");
            Answerlist[1] = new Answers(2, "False");
            if (correctAnswer)
            {
                RightAnswer = Answerlist[0];
            }
            else
            {
                RightAnswer = Answerlist[1];
            }
        }
               public override void DisQues()
        {
            Console.WriteLine("\t" + Header);
            Console.WriteLine(Body);
            for (int i = 0; i < Answerlist.Length; i++)
                Console.WriteLine(Answerlist[i]);
        }
    }
}
