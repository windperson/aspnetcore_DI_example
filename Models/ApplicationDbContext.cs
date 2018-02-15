using Microsoft.EntityFrameworkCore;

namespace DependencyInjectionExample.Models {
    public class ApplicationDbContext : DbContext {
        public DbSet<Character> Characters { get; set; }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating (builder);
        }
    }
}