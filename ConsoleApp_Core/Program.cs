using System;

namespace decorator_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicCourse = new Course();
            var higherCourse = new HigherCourse(basicCourse);
            var advancedCourse = new AdvancedCourse(higherCourse);
            Console.WriteLine("|  Topics of course     |     Cost of course  |");
            Console.WriteLine("|-----------------------|---------------------|");
            Console.WriteLine("| "+basicCourse.GetTopics() + "   |    " + basicCourse.GetCost()+" |");
            Console.WriteLine("|-----------------------|---------------------|");
            Console.WriteLine("| " + higherCourse.GetTopics() + "    |   " + higherCourse.GetCost() + " |");
            Console.WriteLine("|-----------------------|---------------------|");
            Console.WriteLine("| " + advancedCourse.GetTopics() + "   |    " + advancedCourse.GetCost() + " |");
            Console.WriteLine("|-----------------------|---------------------|");

            Console.ReadLine();
        }
    }
}
