using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    public class Course
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Course(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name,Grade);
        }
    }
}
