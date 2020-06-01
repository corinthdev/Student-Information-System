using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SIS.Configuration;
using SIS.Web;

namespace SIS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SISDbContextFactory : IDesignTimeDbContextFactory<SISDbContext>
    {
        public SISDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SISDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SISDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SISConsts.ConnectionStringName));

            return new SISDbContext(builder.Options);
        }
    }
}
