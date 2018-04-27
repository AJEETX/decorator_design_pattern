using System;

namespace decorator_design_pattern
{
    interface ICourse
    {
        string GetName();
        double GetCost();
    }
    class Course : ICourse
    {
        public Course()
        {
            Console.WriteLine("This is Basic school-level course");
        }
        public double GetCost(){return 10;}
        public string GetName(){return "Basic programming";}
    }
}
