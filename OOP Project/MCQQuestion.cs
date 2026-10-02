using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    /// <summary>
    /// Represents a Multiple Choice Question (MCQ)[cite: 6].
    /// </summary>
    internal class MCQQuestion : Question
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MCQQuestion"/> class[cite: 6].
        /// </summary>
        /// <param name="header">The header/title of the question[cite: 6].</param>
        /// <param name="body">The question prompt text[cite: 6].</param>
        /// <param name="mark">The mark allocated for the question[cite: 6].</param>
        /// <param name="answers">An array of possible answer options[cite: 6].</param>
        /// <param name="rightAnswerId">The ID corresponding to the correct answer choice[cite: 6].</param>
        public MCQQuestion(string header, string body, int mark, Answer[] answers, int rightAnswerId) : base(
                header, body, mark, answers, FindCorrectAnswer(answers, rightAnswerId))
        { }

        /// <summary>
        /// Searches through the answer options to find the matching correct answer by ID[cite: 6].
        /// </summary>
        /// <param name="answers">Array of answers to search[cite: 6].</param>
        /// <param name="rightAnswerId">ID of the correct answer[cite: 6].</param>
        /// <returns>The matching <see cref="Answer"/> instance[cite: 6].</returns>
        /// <exception cref="ArgumentException">Thrown when no answer matches the specified ID[cite: 6].</exception>
        private static Answer FindCorrectAnswer(Answer[] answers, int rightAnswerId)
        {
            foreach (Answer answer in answers)
            {
                if (answer.AnswerId == rightAnswerId)
                    return answer;
            }

            throw new ArgumentException(
                "Correct answer ID does not exist.");
        }

        /// <summary>
        /// Returns a formatted string representing the MCQ question[cite: 6].
        /// </summary>
        /// <returns>A string prefixed with "[MCQ]"[cite: 6].</returns>
        public override string ToString()
        {
            return $"[MCQ] {base.ToString()}";
        }
    }
}