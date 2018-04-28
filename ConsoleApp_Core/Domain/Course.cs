using System;

namespace decorator_design_pattern
{
    interface ICourse
    {
        string GetTopics();
        double GetCost();
    }
    class Course : ICourse
    {
        public Course()
        {
            //Console.WriteLine("This is Basic school-level course");
        }
        public double GetCost(){return 10;}
        public string GetTopics(){return "Basic programming";}
    }
}
