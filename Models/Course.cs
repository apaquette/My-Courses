namespace MyCourses.Models;

public class Course{
    public Course(int year, string title, string code, DateTime start, DateTime end){
        Year = year;
        Title = title;
        Code = code;
        Start = start;
        End = end;
        Assignments = new();
    }

    public int Year { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<Assignment> Assignments { get; set; }

}