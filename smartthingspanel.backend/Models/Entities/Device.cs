using System;

namespace smartthingspanel.backend.Models.Entities
{
    public class Device
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}