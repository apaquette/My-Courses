using MyCourses.Models;

namespace MyCourses.Services;

public class FakeDbService : IFakeDbService
{
    public List<Course> GetCourses()
    {
        return new List<Course>(){
            new Course(2022, "Programming in C#", "CIS325", new DateTime(2022, 09, 07), new DateTime(2022, 12, 16)),
            new Course(2023, "Tech Support", "CST230", new DateTime(2023, 01, 09), new DateTime(2022, 04, 21))
        };
        
    }

    public Course GetCourse(string code)
    {
        return GetCourses().Where(c => c.Code == code).First();
    }

    public List<Assignment> GetAssignments()
    {
        return new List<Assignment>(){
            new Assignment("Lists & Loops", GetCourse("CIS325"), DateTime.Now, DateTime.Now.AddDays(7)),
            new Assignment("Delegates & Events", GetCourse("CIS325"), DateTime.Now.AddDays(-3), DateTime.Now.AddDays(4)),
            new Assignment("ITIL & Request Types", GetCourse("CST230"), new DateTime(2023,01, 14), new DateTime(2023,01, 14))
        };
    }
}