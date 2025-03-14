using lemonPharmacy.Common.Infrastructure.EfCore.Db;
using lemonPharmacy.Domain;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace lemonPharmacy.Infrastructure.DBContext
{
    public class lemonPharmacyDbModelBuilder : ICustomModelBuilder
    {
        private const string Schema = "dbo";
        public void Build(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<InsuranceCompany>(entity =>
            {
                entity.ToTable("InsuranceCompany");
            });
        }
    }
}
