using WebApplication6.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class WebApplication6Context :IdentityDbContext<ApplicationUser>
    {
        public WebApplication6Context (DbContextOptions<WebApplication6Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }

        public DbSet<WebApplication6.Models.Client> Client { get; set; } = default!;

        public DbSet<WebApplication6.Models.Autovehicul> Autovehicul { get; set; }
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    void IEntityTypeConfiguration<ApplicationUser>.Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}