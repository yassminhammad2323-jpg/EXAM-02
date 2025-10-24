﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_02
{
    internal class Answers
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        public Answers(int id, string? text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString()
        {
            return AnswerId + "is" + AnswerText;
        }
    }
}
