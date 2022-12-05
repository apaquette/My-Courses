using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCourses.Services;
using MyCourses.Models;

namespace MyCourses.Pages.Courses{
    
    public class DetailsModel : PageModel
    {
        private IFakeDbService _myAppData;

        public DetailsModel(IFakeDbService myAppData)
        {
            _myAppData = myAppData;
        }

        public void OnGet(string code){
            Course = _myAppData.GetCourse(code);
        }
        public Course Course { get; set; }
    }
}
