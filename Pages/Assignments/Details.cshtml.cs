using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyCourses.Data;
using MyCourses.Models;

namespace MyCourses.Pages.Assignments
{
    public class DetailsModel : PageModel
    {
        private readonly MyCourses.Data.MyCoursesDbContext _context;

        public DetailsModel(MyCourses.Data.MyCoursesDbContext context)
        {
            _context = context;
        }

        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignments
                .Include(a => a.Course).FirstOrDefaultAsync(m => m.AssignmentId == id);

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
