using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class LagopusClass
    {
        private string className;
        private List<Student> students;
        private List<Mentor> mentors;

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"Lagopus {className} class has {students.Count} students and {mentors.Count} mentors.");
        }

        public LagopusClass(string className)
        {
            this.className = className;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }
    }
}
