using Microsoft.AspNetCore.Identity;

namespace SmartCamp.Core.Domain.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
