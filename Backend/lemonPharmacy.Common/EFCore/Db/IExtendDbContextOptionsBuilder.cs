using Microsoft.EntityFrameworkCore;

namespace lemonPharmacy.Common.Infrastructure.EfCore.Db
{
    public interface IExtendDbContextOptionsBuilder
    {
        DbContextOptionsBuilder Extend(DbContextOptionsBuilder optionsBuilder,
            IDbConnStringFactory connectionStringFactory, string assemblyName);
    }
}
