using Microsoft.AspNetCore.Identity;

namespace CleanArchAuth.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public string Fullname { get; set; } = string.Empty;
}
