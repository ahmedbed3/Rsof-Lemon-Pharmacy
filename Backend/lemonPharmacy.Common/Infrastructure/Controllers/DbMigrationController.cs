using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lemonPharmacy.Common.Infrastructure.EfCore.Extensions;
using Asp.Versioning;

namespace lemonPharmacy.Common.Infrastructure.AspNetCore.All.Controllers
{
    [Route("")]
    [ApiVersionNeutral]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DbMigrationController : Controller
    {
        private readonly IServiceProvider _svcProvider;

        public DbMigrationController(IServiceProvider svcProvider)
        {
            _svcProvider = svcProvider;
        }

        [HttpGet("/db-migration")]
        public Task<bool> Index()
        {
            return Task.Run(() => _svcProvider.MigrateDbContext() != null);
        }
    }
}
