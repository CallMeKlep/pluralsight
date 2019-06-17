using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_fundamentals_01
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        List<double> grades;
    }
}
