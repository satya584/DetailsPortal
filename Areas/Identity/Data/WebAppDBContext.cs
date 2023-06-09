﻿using AspnetCoreWebApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreWebApp.Data;

public class WebAppDBContext : IdentityDbContext<ApplicationUser>
{
    public WebAppDBContext(DbContextOptions<WebAppDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.Entity<ApplicationUser>().Property(e=> e.UserAdress).HasMaxLength(256);
        builder.Entity<ApplicationUser>().Property(e => e.UserManagerName).HasMaxLength(256);
    }
}
