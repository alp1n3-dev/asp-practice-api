namespace asp_practice_api.Models;

public class CourseModel
{
    public int Id { get; set; }
    public bool IsPreorder { get; set; }
    public required string CourseUrl { get; set; }
    public required string CourseType { get; set; }
    public required string CourseName { get; set; }
    public int CourseLessonCount { get; set; }
    public int CourseLengthInHours { get; set; }
    public required string ShortDescription { get; set; }
    public required string CourseImage { get; set; }
    public int CoursePrice { get; set; }
    public required string CoursePreviewLink { get; set; }
}