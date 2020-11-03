using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public int Count { get { return this.students.Count(); } }
        public int Capacity { get; set; }
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>();
        }
        public string RegisterStudent(Student student)
        {
            if (this.Count < this.Capacity)
            {
                this.students.Add(student);
                return ($"Added student {student.FirstName} {student.LastName}");
            }
            else
            {
                return $"No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            if (this.students.Any(x => x.FirstName == firstName && x.LastName == lastName))
            {
                var student = this.students.Find(x => x.FirstName == firstName && x.LastName == lastName);
                this.students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
            }
            return $"Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            var studentsLearningSubject = this.students.Where(x => x.Subject == subject).ToList();
            if (studentsLearningSubject.Any())
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");
                foreach (var student in studentsLearningSubject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return sb.ToString().Trim();
            }
            return "No students enrolled for the subject";
        }
        public int GetStudentsCount()
        {
            return this.Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            var student = this.students.Find(x => x.FirstName == firstName && x.LastName == lastName);
            return student;
        }
    }
}
