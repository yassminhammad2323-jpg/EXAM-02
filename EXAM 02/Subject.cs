using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_02
{
    internal class Subject
    {
        int SubjectId { get; set; }
        string? SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateEx(Exam exam)
        {
            ExamOfSubject = exam;

        }
        public override string ToString()
        {
            return "Subject: " + SubjectName + " (ID: " + SubjectId + ")";
        }
    }
}