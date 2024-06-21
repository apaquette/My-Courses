using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCourses.Data;
using MyCourses.Models;

namespace MyCourses.Pages.Assignments
{
    public class CreateModel : PageModel
    {
        private readonly MyCourses.Data.MyCoursesDbContext _context;

        public CreateModel(MyCourses.Data.MyCoursesDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(){
            List<SelectListItem> CoursesSelectOptions = new();
            foreach (Course c in _context.Courses){
                CoursesSelectOptions.Add(new SelectListItem($"{c.Title} ({c.Code})", c.CourseId.ToString()));
            }

            CourseOptions = new SelectList(CoursesSelectOptions, "Value", "Text");
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(Assignment is not null){
                _context.Assignments?.Add(Assignment);
            }
            
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        
        [BindProperty]
        public Assignment Assignment { get; set; }
        public SelectList? CourseOptions { get; set; }
    }
}
