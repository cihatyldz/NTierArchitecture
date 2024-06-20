using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace NTierArchitecture.Entities.Models;

public sealed class AppUser : IdentityUser<Guid>
{
    public string Name { get; set; }

    public string Lastname { get; set; }
}
