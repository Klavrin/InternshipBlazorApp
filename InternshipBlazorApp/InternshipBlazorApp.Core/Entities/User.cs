namespace InternshipBlazorApp.Core.Entities;

public class User
{
    public string FirstName { get; set; } = string.Empty;
    public string LstName { get; set; } = string.Empty;
    public int Age { get; set; }
    public bool IsMarried { get; set; }
}