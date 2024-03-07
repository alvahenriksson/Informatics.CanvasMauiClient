using Informatics.CanvasMauiClient.Models; namespace Informatics.CanvasMauiClient;
public interface ICourseService
{
    Task<List<Course>> GetCourses();
    Task<Course> GetCourse(int id);
}