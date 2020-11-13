


namespace TheTest.Server.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using TheTest.Server.Data.Models;

    public class TheTestDbContext : IdentityDbContext<User>
    {
        public TheTestDbContext(DbContextOptions<TheTestDbContext> options)
            : base(options)
        {
        }
        public DbSet<Data.Models.Personne> Personne { get; set; }
    }
}
