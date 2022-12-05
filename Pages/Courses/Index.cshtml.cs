using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCourses.Services;
using MyCourses.Models;

namespace MyCourses.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private IFakeDbService _myAppData;

        public IndexModel(IFakeDbService myAppData)
        {
            _myAppData = myAppData;
        }

        public void OnGet(){
        }

        public List<Course> Courses => _myAppData.GetCourses();
    }
}
