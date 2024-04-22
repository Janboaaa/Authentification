namespace Backend.WebApi.Data.Requests
{
    public class LoginRequest
    {
        public string AuthName { get; set; }
        public string Key { get; set; }
        public bool RememberMe { get; set; }
    }
}