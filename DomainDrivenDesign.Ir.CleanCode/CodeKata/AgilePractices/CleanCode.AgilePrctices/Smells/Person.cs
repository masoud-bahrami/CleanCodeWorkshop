using System.Collections.Generic;

namespace CleanCode.AgilePractices.Smells
{
    public class Person
    {
        public IList<Courses> Courses { get; private set; }

        private void SetCourses(IList<Courses> courses) => Courses = courses;
    }

    public class Courses
    {
    }
}