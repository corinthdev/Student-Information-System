using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SIS.EntityFrameworkCore
{
    public static class SISDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SISDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SISDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
