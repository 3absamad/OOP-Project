using System;
using System.Collections.Generic;
using System.Text;
using static OOP_Project.Program;

namespace OOP_Project
{
    /// <summary>
    /// Specifies the types of exams that can be generated[cite: 10].
    /// </summary>
    public enum ExamType
    {
        /// <summary>Represents a Final Exam[cite: 10].</summary>
        Final,
        /// <summary>Represents a Practical Exam[cite: 10].</summary>
        Practical
    }

    /// <summary>
    /// Represents an academic subject that manages an associated exam[cite: 10].
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Gets or sets the unique subject identifier[cite: 10].
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// Gets or sets the name of the subject[cite: 10].
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// Gets the exam associated with this subject[cite: 10].
        /// </summary>
        public Exam? Exam { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class[cite: 10].
        /// </summary>
        /// <param name="subjectId">The unique ID for the subject[cite: 10].</param>
        /// <param name="subjectName">The name of the subject[cite: 10].</param>
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        /// <summary>
        /// Instantiates an exam object (Final or Practical) for this subject[cite: 10].
        /// </summary>
        /// <param name="type">The type of exam to create[cite: 10].</param>
        /// <param name="time">The allocated duration for the exam[cite: 10].</param>
        /// <exception cref="ArgumentException">Thrown when an invalid exam type is provided[cite: 10].</exception>
        public void CreateExam(ExamType type, TimeSpan time)
        {
            switch (type)
            {
                case ExamType.Final:
                    Exam = new FinalExam(time);
                    break;
                case ExamType.Practical:
                    Exam = new PracticalExam(time);
                    break;
                default:
                    throw new ArgumentException("Invalid exam type");
            }
        }

        /// <summary>
        /// Returns a formatted string representation of the subject[cite: 10].
        /// </summary>
        /// <returns>Formatted string containing Subject ID and Subject Name[cite: 10].</returns>
        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, " +
                   $"Subject Name: {SubjectName}";
        }
    }
}