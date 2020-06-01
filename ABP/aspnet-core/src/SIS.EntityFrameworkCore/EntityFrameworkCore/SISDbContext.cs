using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SIS.Authorization.Roles;
using SIS.Authorization.Users;
using SIS.MultiTenancy;

namespace SIS.EntityFrameworkCore
{
    public class SISDbContext : AbpZeroDbContext<Tenant, Role, User, SISDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SISDbContext(DbContextOptions<SISDbContext> options)
            : base(options)
        {
        }
    }
}
