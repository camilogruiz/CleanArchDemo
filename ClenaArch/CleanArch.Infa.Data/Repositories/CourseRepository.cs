using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using CleanArh.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Infa.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Add(course);
        }

        public IQueryable<Course> GetCourses()
        {
            return _ctx.Courses;
        }        
    }
}
