using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using smartthingspanel.backend.Models;
using smartthingspanel.backend.Models.Entities;
using smartthingspanel.backend.Models.Responses;

namespace smartthingspanel.backend.Controllers
{
    public class TilesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            // authorise credentials and get a token
            var token = Guid.NewGuid().ToString();
            var response = new TilesResponse
            {
                Tiles = new List<Tile>
                {
                    new Tile { DeviceId = "1", DeviceName = "Switch 1", DeviceValue = "on", Name = "Switch One", State = TileState.Active },
                    new Tile { DeviceId = "2", DeviceName = "Switch 2", DeviceValue = "on", Name = "Switch One", State = TileState.Active },
                    new Tile { DeviceId = "3", DeviceName = "Switch 3", DeviceValue = "on", Name = "Switch One", State = TileState.Active },
                    new Tile { DeviceId = "4", DeviceName = "Switch 4", DeviceValue = "on", Name = "Switch One", State = TileState.Active },
                    new Tile { DeviceId = "5", DeviceName = "Switch 5", DeviceValue = "on", Name = "Switch One", State = TileState.Active }
                }
            };
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
