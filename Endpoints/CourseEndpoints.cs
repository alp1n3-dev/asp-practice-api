using asp_practice_api.Data;

namespace asp_practice_api.Endpoints;

public static class CourseEndpoints
{
    public static void AddCourseEndpoints(this WebApplication app)
    {
        app.MapGet("/courses", LoadAllCourses);
        app.MapGet("/courses/{id}", LoadCourseById);
    }

    private static IResult LoadAllCourses(
        CourseData data,
        string? courseType,
        string? search)
    {
        var output = data.Courses;

        if (string.IsNullOrEmpty(courseType) is false)
        {
            output.RemoveAll(x => string.Compare(
                x.CourseType, 
                courseType, 
                StringComparison.OrdinalIgnoreCase) is not 0);
        }
        
        return Results.Ok(output); 
    }

    private static IResult LoadCourseById(CourseData data, int id)
    {
        var output = data.Courses.SingleOrDefault(x => x.Id == id);

        if (output is null)
        {
            return Results.NotFound();
        }
        
        return Results.Ok(output);
    }
}