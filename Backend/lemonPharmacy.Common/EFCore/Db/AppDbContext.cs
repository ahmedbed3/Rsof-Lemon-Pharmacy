using lemonPharmacy.Common.Infrastructure.EfCore.Extensions;
using lemonPharmacy.Common.Infrastructure.EFCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace lemonPharmacy.Common.Infrastructure.EfCore.Db
{
    public abstract class AppDbContextIdentity : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly IConfiguration _config;
        protected AppDbContextIdentity(DbContextOptions options, IConfiguration config)
           : base(options)
        {
            _config = config;

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var typeToRegisters = new List<Type>();
            var ourModules = _config.LoadFullAssemblies();

            typeToRegisters.AddRange(ourModules.SelectMany(m => m.DefinedTypes));

            builder.RegisterEntities(typeToRegisters);

            builder.RegisterConvention();

            base.OnModelCreating(builder);

            builder.RegisterCustomMappings(typeToRegisters);
        }
    }



    public abstract class AppDbContext : DbContext
    {
        private readonly IConfiguration _config;


        protected AppDbContext(DbContextOptions options, IConfiguration config)
            : base(options)
        {
            _config = config;

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var typeToRegisters = new List<Type>();
            var ourModules = _config.LoadFullAssemblies();

            typeToRegisters.AddRange(ourModules.SelectMany(m => m.DefinedTypes));

            builder.RegisterEntities(typeToRegisters);

            builder.RegisterConvention();

            base.OnModelCreating(builder);

            builder.RegisterCustomMappings(typeToRegisters);
        }


    }
}
