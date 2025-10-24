namespace EXAM_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Subject sub = new Subject(1, "Electrical");

            Console.Write("Enter Exam number (final=>1 or practical=>2): ");
            int examType = int.Parse(Console.ReadLine());
            //final exam-----------------
            if (examType == 1)
            { 
                Final_Exam FlExam = new Final_Exam(40, 3);
                //Q1------------------
                FlExam.Questions[0] = new TrueorFalse("Q1", " CURRENT Intensity UNIT is amp?", 1, true);
                //Q2-------------------
                Answers[] mcqAnswers = new Answers[4];
                mcqAnswers[0] = new Answers(1, "AMP");
                mcqAnswers[1] = new Answers(2, "OHM");
                mcqAnswers[2] = new Answers(3, "VOLT");
                mcqAnswers[3] = new Answers(4, "watte");

                FlExam.Questions[1] = new MCQ("Q2", "Resistanc unit is ?", 1, 2, mcqAnswers);
                sub.CreateEx(FlExam);
              
            }
            else
            {
                Practical_Exam pracExam = new Practical_Exam(40, 1);

                Answers[] mcqAnswers = new Answers[4];
                mcqAnswers[0] = new Answers(1, "ohm");
                mcqAnswers[1] = new Answers(2, "amp");
                mcqAnswers[2] = new Answers(3, "volt");
                mcqAnswers[3] = new Answers(4, "watte");

                pracExam.Questions[1] = new MCQ("Q1", "Resistanc unit is ?", 1, 2, mcqAnswers);
                
                sub.CreateEx(pracExam);
                
            }

            Console.WriteLine(sub);
            sub.ExamOfSubject.ShowExam();
        }
    }
}
        
    

