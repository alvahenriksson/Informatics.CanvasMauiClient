using System.Text.Json.Serialization; namespace Informatics.CanvasMauiClient.Models;
public record class Course
{
    [JsonPropertyName("id")]
    public int CourseCode { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("start_at")]
    public string CourseStart { get; set; }
}