﻿using System;

namespace decorator_design_pattern
{
    class HigherCourse : CourseDecorator
    {
        public HigherCourse(ICourse _course) : base(_course)
        {
            Console.WriteLine("This is bachelor degree course");
        }
        public override double GetCost()
        {
            return _course.GetCost() + 2;
        }

        public override string GetName()
        {
            return _course.GetName() + ", real-time projects";
        }
    }
}
