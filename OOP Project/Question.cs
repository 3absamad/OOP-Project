using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    /// <summary>
    /// Abstract base class representing an examination question[cite: 9].
    /// Implements <see cref="ICloneable"/> and <see cref="IComparable{T}"/>[cite: 9].
    /// </summary>
    public abstract class Question : ICloneable, IComparable<Question>
    {
        /// <summary>
        /// Gets or sets the question header/title[cite: 9].
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Gets or sets the main body text of the question[cite: 9].
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the mark/score value attributed to this question[cite: 9].
        /// </summary>
        public int Mark { get; set; }

        /// <summary>
        /// Gets or sets the array of available answer choices[cite: 9].
        /// </summary>
        public Answer[] Answers { get; set; }

        /// <summary>
        /// Gets or sets the correct answer choice[cite: 9].
        /// </summary>
        public Answer RightAnswer { get; set; }

        /// <summary>
        /// Gets or sets the answer ID selected by the student[cite: 9].
        /// </summary>
        public int? StudentAnswerID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class with specified parameters[cite: 9].
        /// </summary>
        /// <param name="header">The header of the question[cite: 9].</param>
        /// <param name="body">The body text of the question[cite: 9].</param>
        /// <param name="mark">The mark allocated for the question[cite: 9].</param>
        /// <param name="answers">The array of answer options[cite: 9].</param>
        /// <param name="rightAnswer">The correct answer[cite: 9].</param>
        public Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class with default values[cite: 9].
        /// </summary>
        public Question() : this("Unknown", "Unknown", 0, new Answer[0], new Answer()) { }

        /// <summary>
        /// Displays the question details and all available answer choices to the console[cite: 9].
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine($"{Header} ({Mark} Marks)");
            Console.WriteLine($"{Body}");

            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }

        /// <summary>
        /// Performs a deep copy of the question, including cloning its answers array and right answer reference[cite: 9].
        /// </summary>
        /// <returns>A new cloned instance of the question[cite: 9].</returns>
        public virtual object Clone()
        {
            Answer[] copiedAnswers =
                Array.ConvertAll(Answers,
                    answer => (Answer)answer.Clone());

            Answer copiedRightAnswer =
                (Answer)RightAnswer.Clone();

            Question copy = (Question)MemberwiseClone();

            copy.Answers = copiedAnswers;
            copy.RightAnswer = copiedRightAnswer;

            return copy;
        }

        /// <summary>
        /// Compares the mark value of this question against another question instance[cite: 9].
        /// </summary>
        /// <param name="other">The question object to compare[cite: 9].</param>
        /// <returns>1 if greater, -1 if smaller, 0 if marks are equal[cite: 9].</returns>
        public int CompareTo(Question? other)
        {
            if (other == null)
            {
                return 1;
            }
            else if (this.Mark < other?.Mark)
            {
                return -1;
            }
            else if (this.Mark > other?.Mark)
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Returns a basic string summary of the question[cite: 9].
        /// </summary>
        /// <returns>String formatted as "{Header}: {Body} [{Mark} Marks]"[cite: 9].</returns>
        public override string ToString()
        {
            return $"{Header}: {Body} [{Mark} Marks]";
        }
    }
}