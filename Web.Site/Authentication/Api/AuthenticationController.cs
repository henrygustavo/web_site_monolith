using Microsoft.AspNetCore.Mvc;
using Web.Site.Authentication.Application.Dto;
using Web.Site.Authentication.Application.Service;

namespace Web.Site.Authentication.Api
{
    [Produces("application/json")]
    [Route("api/auth")]
    public class AuthenticationController: Controller
    {

        IAuthenticationAplicationService _authenticationAplicationService;
        public AuthenticationController(IAuthenticationAplicationService authenticationAplicationService)
        {
            _authenticationAplicationService = authenticationAplicationService;
        }

        [HttpPost]
        public IActionResult SignUp(AuthenticationDTO model)
        {
            _authenticationAplicationService.SignUp(model);
            return Ok("SignUp was  good");
        }
    }
}
