using MyCourses.Models;

namespace MyCourses.Services;

public interface IFakeDbService
{
    List<Course> GetCourses();
    Course GetCourse(string code);
    List<Assignment> GetAssignments();
}