namespace decorator_design_pattern
{
    abstract class CourseDecorator : ICourse
    {
        protected ICourse _course;
        public CourseDecorator(ICourse course)
        {
            _course= course;
        }
        public virtual double GetCost()
        {
            return _course.GetCost();
        }

        public virtual string GetName()
        {
            return _course.GetName();
        }
    }
}
