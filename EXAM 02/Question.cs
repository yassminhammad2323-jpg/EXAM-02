using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_02
{
    internal class Question: IComparable<Question>
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answers[] Answerlist;
        public Answers RightAnswer;

        public Question(string? header, string? body, int mark)
        {   Header = header;
            Body = body;
            Mark = mark;
        
        }
       

        public virtual void DisQues() {
            Console.WriteLine("----------------------------------------------");
        }

        public int CompareTo(Question other)
        {
            return this.Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return Header + "." + Body + " (" + Mark + " Marks)";
        }
    }
}
