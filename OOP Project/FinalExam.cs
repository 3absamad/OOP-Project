using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OOP_Project
{
    /// <summary>
    /// Represents a final examination which evaluates and displays student scores[cite: 5].
    /// </summary>
    public class FinalExam : Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinalExam"/> class with a specified duration[cite: 5].
        /// </summary>
        /// <param name="time">The duration for the final exam[cite: 5].</param>
        public FinalExam(TimeSpan time) : base(time)
        {
        }

        /// <summary>
        /// Displays all questions, evaluates the student's selected answers against right answers, and displays the total score[cite: 5].
        /// </summary>
        public override void ShowExam()
        {
            Console.WriteLine("\n========== FINAL EXAM ==========");
            Console.WriteLine($"Duration: {TimeOfExam}");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine("================================");
            Console.WriteLine();


            int grade = 0;
            int totalMarks = 0;

            foreach (Question question in Questions)
            {
                question.Display();

                totalMarks += question.Mark;

                if (question.StudentAnswerID == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Grade: {grade}/{totalMarks}");
        }
    }
}