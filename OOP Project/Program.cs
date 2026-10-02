namespace OOP_Project
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Subject subject =
                new Subject(101, "C# Programming");

            Console.WriteLine(subject);

            // Create Final Exam
            subject.CreateExam(
                ExamType.Final,
                TimeSpan.FromMinutes(60));

            // Question 1: True/False
            Question q1 = new TFQuestion(
                "[True Or False] Question 1",
                "C# is an object-oriented programming language.",
                2,
                true);

            q1.StudentAnswerID = 1;

            // Question 2: MCQ
            Answer[] answers2 =
            {
                new Answer(1, "Java"),
                new Answer(2, "C#"),
                new Answer(3, "Python"),
                new Answer(4, "HTML")
            };

            Question q2 = new MCQQuestion(
                "[MCQ] Question 2",
                "Which language is developed by Microsoft?",
                3,
                answers2,
                2);

            q2.StudentAnswerID = 2;

            // Question 3: MCQ
            Answer[] answers3 =
            {
                new Answer(1, "Console.WriteLine()"),
                new Answer(2, "print()"),
                new Answer(3, "echo()"),
                new Answer(4, "Write()")
            };

            Question q3 = new MCQQuestion(
                "[MCQ] Question 3",
                "Which method prints text in C#?",
                5,
                answers3,
                1);

            q3.StudentAnswerID = 2;

            // Add questions to exam
            subject.Exam!.AddQuestion(q1);
            subject.Exam.AddQuestion(q2);
            subject.Exam.AddQuestion(q3);

            // Display exam
            subject.Exam.ShowExam();

            // Demonstrate ICloneable
            Question copiedQuestion =
                (Question)q2.Clone();


            Console.WriteLine("Cloned Question:");
            Console.WriteLine(copiedQuestion);

            // Demonstrate IComparable
            Console.WriteLine(
                $"Compare Q1 and Q2 by marks: " +
                q1.CompareTo(q2));

            Console.WriteLine(
                $"Compare Answer 1 and Answer 2 by ID: " +
                answers2[0].CompareTo(answers2[1]));

            // Demonstrate ToString
            Console.WriteLine(subject.ToString());

        }
    }
}
