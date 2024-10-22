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
    public class DetailsModel : PageModel
    {
        private readonly MyCoursesDbContext _context;

        public DetailsModel(MyCoursesDbContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if(_context.Courses is not null){
                Course = await _context.Courses.Include(c => c.Assignments).FirstOrDefaultAsync(m => m.CourseId == id);
            }

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
