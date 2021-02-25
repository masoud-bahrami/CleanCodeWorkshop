using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode.AgilePractices.BadSmells._10Primitive_Obsession
{
    public class Student
    {
        public List<Course> Courses { get; private set; }

        public void AddCourse(Course course)
        {
            if (Courses.Count > 5)
                throw new Exception("Maximum allowed is 4");
            
            if(Courses.Any(c=>c.Name ==course.Name))
                throw new Exception("Already added");

            Courses.Add(course);
        }

    }

    public class Course
    {
        public string Name { get; set; }
    }
}