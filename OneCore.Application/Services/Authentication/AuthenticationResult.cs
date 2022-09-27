namespace OneCore.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string firstName,
    string lastName,
    string email,
    string token
);