namespace Backend.WebApi.Data.Models;

public class User(int nameId, string key, bool rememberMe = false)
{
    public int Id { get; init; }
    public int NameId { get; init; } = nameId;
    public Name Name { get; init; }
    public string Key { get; set; } = key;
    public bool RememberMe { get; set; } = rememberMe;
}