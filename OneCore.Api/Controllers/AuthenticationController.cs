using Microsoft.AspNetCore.Mvc;
using OneCore.Contracts.Authentication;
using OneCore.Application.Services.Authentication;

namespace OneCore.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request) {
        var authResult = _authenticationService.Register(
            request.firstName,
            request.lastName,
            request.email,
            request.password);
        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.firstName,
            authResult.lastName,
            authResult.email,
            authResult.token);
        
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request) {
        var authResult = _authenticationService.Login(           
            request.email,
            request.password);
        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.firstName,
            authResult.lastName,
            authResult.email,
            authResult.token);
        
        return Ok(response);
    }
}