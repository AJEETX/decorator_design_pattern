# decorator design pattern ![GitHub release](https://img.shields.io/github/release/ajeetx/decorator_design_pattern.svg?style=for-the-badge) ![Maintenance](https://img.shields.io/maintenance/yes/2018.svg?style=for-the-badge)

![Travis](https://img.shields.io/travis/AJEETX/decorator_design_pattern.svg) |![GitHub Release Date](https://img.shields.io/github/release-date/ajeetx/decorator_design_pattern.svg)|
| --- | --- |

[![.Net Framework](https://img.shields.io/badge/DotNet-2.0-blue.svg?style=plastic)](https://www.microsoft.com/en-au/download/details.aspx?id=1639) | ![GitHub language count](https://img.shields.io/github/languages/count/ajeetx/decorator_design_pattern.svg) | ![GitHub top language](https://img.shields.io/github/languages/top/ajeetx/decorator_design_pattern.svg) |![GitHub repo size in bytes](https://img.shields.io/github/repo-size/ajeetx/decorator_design_pattern.svg) 
| ---          | ---        | ---      | ---        | 

---------------------------------------
## Introduction

A very simple Decorator design pattern implementation. The effort is to display the usage of choosing education domain courses.  

## Repository codebase
 
The repository consists of a project:
1) Asp.Net Core2 Console 

## Features
The education courses have been created with basic as the minimum .And in order to choose other optional courses at runtime the decorator pattern comes.

- The basic course is minimum bare with min cost and min topics 
```
interface ICourse
{
   string GetTopics();
   double GetCost();
}
```
- Course is the basic minimum which inherits the ICourse interface
```
    class Course : ICourse
    {
        public double GetCost(){return 10;}
        public string GetTopics(){return "Basic programming";}
    }
```    
- The decorator is an abstract class which inherits the ICourse interface
```
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
```
- The higher course is basic course plus more topics with more cost
```
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

    public override string GetTopics()
    {
    	return _course.GetTopics() + ", real-time projects";
    }
}
```
- The advanced course is basic plus higher course plus more topics with more cost
```
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

    public override string GetTopics()
    {
    	return _course.GetTopics() + ", industry-projects";
    }
}
```

### Support or Contact

Having any trouble? Check out our [documentation](https://github.com/AJEETX/decorator_design_pattern/blob/master/README.md) or [contact support](mailto:ajeetkumar@email.com) and we’ll help you sort it out.


[![HitCount](http://hits.dwyl.io/ajeetx/decorator_design_pattern/projects/1.svg)](http://hits.dwyl.io/ajeetx/decorator_design_pattern/projects/1) | ![GitHub contributors](https://img.shields.io/github/contributors/ajeetx/decorator_design_pattern.svg?style=plastic)|![license](https://img.shields.io/github/license/ajeetx/decorator_design_pattern.svg?style=plastic)|
 | --- | --- | ---|
