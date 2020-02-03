using erikCorp.ITDevelop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace erikCorp.ITDevelop.Data.ORM
{
    public class ITDevelopDataContext : DbContext
    {
        public ITDevelopDataContext(DbContextOptions<ITDevelopDataContext> options) : base(options)
        {
                
        }

        public DbSet<Mural> Mural { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

    }
}
