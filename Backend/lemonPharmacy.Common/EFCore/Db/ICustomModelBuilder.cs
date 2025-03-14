using Microsoft.EntityFrameworkCore;

namespace lemonPharmacy.Common.Infrastructure.EfCore.Db
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
