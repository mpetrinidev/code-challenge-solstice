using Microsoft.EntityFrameworkCore;

namespace ChallengeMpetrini.Api.Models
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }

        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<State>()
                .HasMany(p => p.Cities)
                .WithOne(p => p.State)
                .HasForeignKey(p => p.State_Id);

            modelBuilder.Entity<City>()
                .HasMany(p => p.Contacts)
                .WithOne(p => p.City)
                .HasForeignKey(p => p.City_Id);
        }
    }
}
