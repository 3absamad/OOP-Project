using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OOP_Project
{
    /// <summary>
    /// Represents a practical examination which reveals the correct answer for each question upon display[cite: 7].
    /// </summary>
    internal class PracticalExam : Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PracticalExam"/> class[cite: 7].
        /// </summary>
        /// <param name="time">The duration of the practical exam[cite: 7].</param>
        public PracticalExam(TimeSpan time) : base(time)
        {
        }

        /// <summary>
        /// Displays each question alongside its designated correct answer[cite: 7].
        /// </summary>
        public override void ShowExam()
        {
            Console.WriteLine("\n======= PRACTICAL EXAM =======");
            Console.WriteLine($"Duration: {TimeOfExam}");
            Console.WriteLine(
                $"Number of Questions: {NumberOfQuestions}");

            foreach (Question question in Questions)
            {
                question.Display();

                Console.WriteLine(
                    $"Correct Answer: {question.RightAnswer.AnswerText}");

                Console.WriteLine();
            }
        }
    }
}