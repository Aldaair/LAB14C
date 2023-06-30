using LAB14C.DataContext;
using LAB14C.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB14C.Services
{
    public class CourseService
    {
        private readonly AppDbContext _context;

        public CourseService()
        {
            _context = App.GetContext();
        }

        public bool Create(Course item)
        {
            try
            {
                _context.Course.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Course> Get()
        {
            return _context.Course.ToList();
        }
    }
}
