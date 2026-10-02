using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    /// <summary>
    /// Abstract base class representing an examination[cite: 4].
    /// </summary>
    public abstract class Exam
    {
        /// <summary>
        /// Gets or sets the duration allowed for completing the exam[cite: 4].
        /// </summary>
        public TimeSpan TimeOfExam { get; set; }

        /// <summary>
        /// Gets the total number of questions in the exam[cite: 4].
        /// </summary>
        public int NumberOfQuestions
        {
            get { return Questions.Count; }
        }

        /// <summary>
        /// Gets or sets the list of questions associated with this exam[cite: 4].
        /// </summary>
        public List<Question> Questions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class with a given time limit[cite: 4].
        /// </summary>
        /// <param name="timeOfExam">The duration of the exam[cite: 4].</param>
        public Exam(TimeSpan timeOfExam)
        {
            TimeOfExam = timeOfExam;
            Questions = new List<Question>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class with a default duration of 30 minutes[cite: 4].
        /// </summary>
        public Exam() : this(TimeSpan.FromMinutes(30))
        {
        }

        /// <summary>
        /// Adds a question to the exam[cite: 4].
        /// </summary>
        /// <param name="question">The question instance to add[cite: 4].</param>
        /// <exception cref="ArgumentException">Thrown when attempting to add a non-MCQ question to a practical exam[cite: 4].</exception>
        public void AddQuestion(Question question)
        {
            if (this is PracticalExam &&
                question is not MCQQuestion)
            {
                throw new ArgumentException(
                    "Practical Exam accepts MCQ questions only.");
            }

            Questions.Add(question);
        }

        /// <summary>
        /// Abstract method to display and execute the exam process[cite: 4].
        /// </summary>
        public abstract void ShowExam();
    }
}