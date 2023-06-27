namespace Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Models
{
    public class AuthResult
    {
        public string? Token { get; set; }
        public User? User { get; set; }
        public string? Message { get; set; }
        // Add any other relevant properties, such as expiration date, refresh token, etc.
    }
}
