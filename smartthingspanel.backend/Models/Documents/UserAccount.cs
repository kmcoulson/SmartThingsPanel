using System;

namespace smartthingspanel.backend.Models.Documents
{
    public class UserAccount : IDocument
    {
        public Guid Id { get; set; }
        public Guid Token { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
    }
}