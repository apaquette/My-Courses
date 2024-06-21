using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyCourses.Data;
using MyCourses.Models;

namespace MyCourses.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly MyCourses.Data.MyCoursesDbContext _context;

        public IndexModel(MyCourses.Data.MyCoursesDbContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
