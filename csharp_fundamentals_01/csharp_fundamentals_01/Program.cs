﻿using System;
using System.Collections.Generic;

namespace csharp_fundamentals_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            Console.WriteLine(result);

            if (args.Length > 0)
            {

            }
        }
    }
}
