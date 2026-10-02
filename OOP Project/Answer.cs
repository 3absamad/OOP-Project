using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    /// <summary>
    /// Represents an individual answer choice for an examination question[cite: 3].
    /// Implements <see cref="ICloneable"/> for object copying and <see cref="IComparable{T}"/> for comparison[cite: 3].
    /// </summary>
    public class Answer : ICloneable, IComparable<Answer>
    {
        /// <summary>
        /// Gets or sets the unique identifier for the answer choice[cite: 3].
        /// </summary>
        public int AnswerId { get; set; }

        /// <summary>
        /// Gets or sets the display text for the answer choice[cite: 3].
        /// </summary>
        public string AnswerText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Answer"/> class with a specified ID and text[cite: 3].
        /// </summary>
        /// <param name="answerId">The unique identifier for the answer[cite: 3].</param>
        /// <param name="answerText">The text content of the answer[cite: 3].</param>
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Answer"/> class with default values[cite: 3].
        /// </summary>
        public Answer() : this(0, "Unknown") { }

        /// <summary>
        /// Creates a new object that is a copy of the current answer instance[cite: 3].
        /// </summary>
        /// <returns>A new <see cref="Answer"/> object with the same AnswerId and AnswerText[cite: 3].</returns>
        public object Clone()
        {
            return new Answer
            {
                AnswerId = this.AnswerId,
                AnswerText = this.AnswerText
            };
        }

        /// <summary>
        /// Compares the current answer instance with another answer instance based on their AnswerId[cite: 3].
        /// </summary>
        /// <param name="other">The answer instance to compare with[cite: 3].</param>
        /// <returns>
        /// A value indicating the relative order of the objects being compared (1 if other is null or current ID is greater, -1 if smaller, 0 if equal)[cite: 3].
        /// </returns>
        public int CompareTo(Answer? other)
        {
            if (other == null)
            {
                return 1;
            }
            else if (this.AnswerId < other?.AnswerId)
            {
                return -1;
            }
            else if (this.AnswerId > other?.AnswerId)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns a formatted string representation of the answer[cite: 3].
        /// </summary>
        /// <returns>A string in the format "{AnswerId}. {AnswerText}"[cite: 3].</returns>
        override public string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }
    }
}