using System;

namespace decorator_design_pattern
{
    class AdvancedCourse : CourseDecorator
    {
        public AdvancedCourse(ICourse _course) : base(_course)
        {
            Console.WriteLine("This is master-degree course");
        }
        public override double GetCost()
        {
            return _course.GetCost() + 4;
        }

        public override string GetName()
        {
            return _course.GetName() + ", industry-projects";
        }
    }
}
