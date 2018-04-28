namespace decorator_design_pattern
{
    abstract class CourseDecorator : ICourse
    {
        protected ICourse _course;
        public CourseDecorator(ICourse course)
        {
            _course= course;
        }
        public abstract double GetCost();
        public abstract string GetTopics();
    }
}
