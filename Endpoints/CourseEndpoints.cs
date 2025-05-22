using asp_practice_api.Data;

namespace asp_practice_api.Endpoints;

public static class CourseEndpoints
{
    public static void AddCourseEndpoints(this WebApplication app)
    {
        app.MapGet("/courses", LoadAllCourses);
    }

    private static IResult LoadAllCourses(CourseData data)
    {
        return Results.Ok(data.Courses); 
    }
}