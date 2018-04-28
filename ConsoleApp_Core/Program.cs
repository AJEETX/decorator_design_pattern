using System;

namespace decorator_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicCourse = new Course();
            Console.WriteLine("Cost of basic course:  " + basicCourse.GetCost());
            Console.WriteLine("Basic course topics: " + basicCourse.GetTopics());
            Console.WriteLine("==================================");

            var higherCourse = new HigherCourse(basicCourse);
            Console.WriteLine("Cost of higher course:  " + higherCourse.GetCost());
            Console.WriteLine("Higher course topics: " + higherCourse.GetTopics());
            Console.WriteLine("==================================");

            var advancedCourse = new AdvancedCourse(higherCourse);
            Console.WriteLine("Cost of advanced course:  " + advancedCourse.GetCost());
            Console.WriteLine("Advanced course topics: " + advancedCourse.GetTopics());
            Console.ReadLine();
        }
    }
}
