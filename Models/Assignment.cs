namespace MyCourses.Models;

public class Assignment {
    public Assignment(string title, Course course, DateTime start, DateTime due)
    {
        Title = title;
        Course = course;
        Start = start;
        Due = due;
    }

    public string Title { get; set; }
    public Course Course { get; set; }
    public DateTime Start { get; set; }
    public DateTime Due  { get; set; }
    
}