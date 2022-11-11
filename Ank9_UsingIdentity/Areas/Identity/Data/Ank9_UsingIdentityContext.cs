using Ank9_UsingIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ank9_UsingIdentity.Data;

public class Ank9_UsingIdentityContext : IdentityDbContext<Ank9_UsingIdentityUser>
{
    public Ank9_UsingIdentityContext(DbContextOptions<Ank9_UsingIdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
