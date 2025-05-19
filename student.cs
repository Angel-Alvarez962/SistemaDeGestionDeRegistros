using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRegistro
{
    class Student
    {
        private string name;
        private double grade;
        private int schoolId;

        public Student(string name, double grade, int schoolId)
        {
            this.name = name;
            this.grade = grade;
            this.schoolId = schoolId;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int SchoolId
        {
            get { return schoolId; }
            set { schoolId = value; }
        }
    }
}