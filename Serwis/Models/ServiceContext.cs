using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Serwis.Models
{
    public class ServiceContext : IdentityDbContext<Worker>
    {
        public DbSet<Worker> workers { get; set; }
        public DbSet<Device> devices { get; set; }
        public DbSet<Intervention> interventions { get; set; }
        public DbSet<Issue> issues { get; set; }


        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
        {

        }
    }
}
