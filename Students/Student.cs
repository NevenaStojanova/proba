using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ID { get; set; }
        public List<Course> courses_list;

        public Student() { }

        public Student(string name, string surname, string id)
        {
            this.Name = name;
            this.Surname = surname;
            this.ID = id;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Surname, Name, ID);
        }
    }
}
