using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_fundamentals_01
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        private List<double> grades;
        private string name;
    }
}
