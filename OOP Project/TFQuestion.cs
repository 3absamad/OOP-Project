using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    /// <summary>
    /// Represents a True/False Question[cite: 11].
    /// </summary>
    internal class TFQuestion : Question
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TFQuestion"/> class with default True/False options[cite: 11].
        /// </summary>
        /// <param name="header">The question header[cite: 11].</param>
        /// <param name="body">The body statement to evaluate[cite: 11].</param>
        /// <param name="mark">The allocated marks[cite: 11].</param>
        /// <param name="correctAnswer">True if the statement is True; otherwise, false[cite: 11].</param>
        public TFQuestion(string header, string body, int mark, bool correctAnswer) : base(header, body, mark,
        new Answer[]
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        },
        correctAnswer ? new Answer(1, "True") : new Answer(2, "False")
          )
        { }

        /// <summary>
        /// Returns a formatted string representing the True/False question[cite: 11].
        /// </summary>
        /// <returns>A string prefixed with "[True/False]"[cite: 11].</returns>
        public override string ToString()
        {
            return $"[True/False] {base.ToString()}";
        }
    }
}