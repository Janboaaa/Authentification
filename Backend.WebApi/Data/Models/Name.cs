namespace Backend.WebApi.Data.Models;

public class Name(string? AuthName, string FirstName, string LastName)
{
    public int Id { get; init; }
    public string? AuthName { get; set; } = AuthName ?? (FirstName + " " + LastName);
    public string FirstName { get; set; } = FirstName;
    public string LastName { get; set; } = LastName;
}