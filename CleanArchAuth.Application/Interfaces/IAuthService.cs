using CleanArchAuth.Application.DTOs;
using Microsoft.AspNetCore.Identity;

namespace CleanArchAuth.Application.Interfaces;

public interface IAuthService
{
    Task<string> Login(LoginDto loginDto);
    Task Logout();
    Task<IdentityResult> Register(RegisterDto registerDto);
    Task<string> RefreshToken(string refreshToken);
}
