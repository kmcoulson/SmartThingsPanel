using System.Net;
using System.Net.Http;
using System.Web.Http;
using smartthingspanel.backend.Models;
using smartthingspanel.backend.Models.Requests;
using smartthingspanel.backend.Models.Responses;
using smartthingspanel.backend.Services;

namespace smartthingspanel.backend.Controllers
{
    public class EventController : ApiController
    {
        private readonly UserDeviceService _userDeviceService;

        public EventController(UserDeviceService userDeviceService)
        {
            _userDeviceService = userDeviceService;
        }
        public EventController() : this(new UserDeviceService()) { }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] EventRequest request)
        {
            var userDevice = _userDeviceService.Get(request.Token, request.DeviceId);
            if (userDevice == null) return Request.CreateErrorResponse(HttpStatusCode.NotFound, string.Format(Constants.ErrorMessages.DeviceNotFound, request.DeviceId));

            userDevice.State = request.State;
            _userDeviceService.AddorUpdate(userDevice);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
