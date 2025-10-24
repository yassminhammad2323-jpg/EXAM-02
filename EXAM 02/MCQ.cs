using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_02
{
    internal class MCQ : Question
    {
        public MCQ(string? header, string? body, int markstr, int RightanswerID, Answers[] answers) : base(header, body, markstr)
        {
            Answerlist = answers;
            for (int i = 0; i < Answerlist.Length; i++)
            {
                if (Answerlist[i].AnswerId == RightanswerID)
                {
                    RightAnswer = answers[i];
                    break;
                }
            }
        }

        public override void DisQues()

        {
           
            for (int i = 0; i < Answerlist.Length; i++)
                Console.WriteLine(Answerlist[i]);
        }
       
            }
    
}
