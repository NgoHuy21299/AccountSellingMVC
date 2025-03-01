using AccountSellingMVC.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccountSellingMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Website> Websites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccountWebsite>()
                .HasKey(aw => new { aw.AccountId, aw.WebsiteId });

            modelBuilder.Entity<AccountWebsite>()
                .HasOne(aw => aw.Account)
                .WithMany(a => a.AccountWebsites)
                .HasForeignKey(aw => aw.AccountId);

            modelBuilder.Entity<AccountWebsite>()
                .HasOne(aw => aw.Website)
                .WithMany(w => w.AccountWebsites)
                .HasForeignKey(aw => aw.WebsiteId);

            // Seed data
            DataSeeder.SeedAccounts(modelBuilder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is EntityAuditBase<int> &&
                            (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = (EntityAuditBase<int>)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.UtcNow;
                }
                entity.UpdatedAt = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is EntityAuditBase<int> &&
                            (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = (EntityAuditBase<int>)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.UtcNow;
                }
                entity.UpdatedAt = DateTime.UtcNow;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
