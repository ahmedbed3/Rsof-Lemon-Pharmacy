using lemonPharmacy.Common.EFCore.Middleware;
using lemonPharmacy.Common.Infrastructure.EfCore.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace lemonPharmacy.Infrastructure.DBContext
{
    public class lemonPharmacyDbContext : AppDbContextIdentity
    {
        public readonly IConfiguration _configuration;
        private readonly AuditInterceptor _auditInterceptor;

        public lemonPharmacyDbContext(DbContextOptions<lemonPharmacyDbContext> options, IConfiguration config, AuditInterceptor auditInterceptor)
            : base(options, config)
        {
            _configuration = config;
            _auditInterceptor = auditInterceptor;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditInterceptor);
        }

    }
}