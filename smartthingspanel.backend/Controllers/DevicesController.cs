using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using smartthingspanel.backend.Models.Documents;
using smartthingspanel.backend.Models.Requests;
using smartthingspanel.backend.Services;

namespace smartthingspanel.backend.Controllers
{
    public class DevicesController : ApiController
    {
        private readonly UserDeviceService _userDeviceService;

        public DevicesController(UserDeviceService userDeviceService)
        {
            _userDeviceService = userDeviceService;
        }
        public DevicesController() : this(new UserDeviceService()) { }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] UpdateDevicesRequest request)
        {
            try
            {
                foreach (var device in request.Devices)
                {
                    var userDevice = new UserDevice
                    {
                        Token = request.Token,
                        Id = device.Id,
                        Name = device.Name,
                        Type = device.Type
                    };

                    _userDeviceService.AddorUpdate(userDevice);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
