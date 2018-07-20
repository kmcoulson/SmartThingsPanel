using System;
using System.Collections.Generic;
using smartthingspanel.backend.Models.Entities;

namespace smartthingspanel.backend.Models.Requests
{
    public class UpdateDevicesRequest
    {
        public Guid Token { get; set; }
        public List<Device> Devices { get; set; }
    }
}