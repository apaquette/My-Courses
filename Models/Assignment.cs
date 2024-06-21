namespace MyCourses.Models;

public class Assignment {
    public int AssignmentId { get; set; }
    public int CourseId { get; set; }
    public string? Title { get; set; }
    public Course? Course { get; set; }
    public DateTime Start { get; set; }
    public DateTime Due  { get; set; }
    
}