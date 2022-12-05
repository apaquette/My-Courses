using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyCourses.Pages;

public class IndexModel : PageModel {
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger) {
        _logger = logger;
        _logger.Log(LogLevel.Information, "Hey there from the constructor");
    }

    public void OnGet(string code) {
        _logger.Log(LogLevel.Information, $"Code: {code}");
    }
    public string CurrentTIme => DateTime.Now.ToString("MMM dd, yyyy @ hh:mm:ss tt");
}
