using System;
using Xunit;

namespace csharp_fundamentals_01.test
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act


            // assert
        }
    }
}
