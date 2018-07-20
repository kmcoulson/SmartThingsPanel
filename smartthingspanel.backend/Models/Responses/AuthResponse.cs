using System;

namespace smartthingspanel.backend.Models.Responses
{
    public class AuthResponse
    {
        public string Username { get; set; }
        public Guid Token { get; set; }
    }
}