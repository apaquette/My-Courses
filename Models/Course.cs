namespace MyCourses.Models;

public class Course{
    public int CourseId { get; set; }
    public int Year { get; set; }
    public string? Instructor {get; set; }
    public string? Title { get; set; }
    public string? Code { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<Assignment>? Assignments { get; set; }

}