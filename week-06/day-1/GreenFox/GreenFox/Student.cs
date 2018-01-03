using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Student : Person, ICloneable
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {            
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public void SkipDays( int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(Name, Age, Gender, previousOrganization);
        }
    }
}
