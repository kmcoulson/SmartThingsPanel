using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using smartthingspanel.backend.Models;
using smartthingspanel.backend.Models.Requests;
using smartthingspanel.backend.Models.Responses;
using smartthingspanel.backend.Services;

namespace smartthingspanel.backend.Controllers
{
    public class AuthController : ApiController
    {
        private readonly UserAccountService _userAccountService;

        public AuthController(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }
        public AuthController() : this(new UserAccountService()) { }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] AuthRequest request)
        {
            var token = _userAccountService.Authenticate(request.Username, request.Password);
            if (token == Guid.Empty) return Request.CreateErrorResponse(HttpStatusCode.Forbidden, Constants.ErrorMessages.AuthError);

            var response = new AuthResponse
            {
                Username = request.Username,
                Token = token
            };
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
