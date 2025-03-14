using lemonPharmacy.Common.EFCore.Middleware;
using lemonPharmacy.Common.Infrastructure.EfCore.Db;
using lemonPharmacy.Common.RestTemplate;
using lemonPharmacy.Common.RestTemplate.Db;
using lemonPharmacy.Infrastructure.DBContext;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCustomTemplate<lemonPharmacyDbContext>(
               svc =>
               {
                   svc.AddScoped<AuditInterceptor>();
                   svc.Replace(ServiceDescriptor.Scoped<IDbConnStringFactory, SqlServerDbConnStringFactory>());
                   svc.Replace(ServiceDescriptor.Scoped<IExtendDbContextOptionsBuilder, DbContextOptionsBuilderFactory>());


               }
           );



var app = builder.Build();
app.UseCustomTemplate();
app.Run();
