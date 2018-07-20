using System;

namespace smartthingspanel.backend.Models.Documents
{
    public class UserDevice : IDocument
    {
        public Guid Id { get; set; }
        public Guid Token { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
    }
}