using System;

namespace smartthingspanel.backend.Models.Requests
{
    public class EventRequest
    {
        public Guid Token { get; set; }
        public Guid DeviceId { get; set; }
        public string State { get; set; }
    }
}