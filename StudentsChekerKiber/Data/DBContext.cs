using Microsoft.EntityFrameworkCore;

using StudentsChekerKiber.Data.Entity;
using StudentsChekerKiber.Exceptions;

using System;
using System.Linq;

namespace StudentsChekerKiber.Data
{
    public class DBContext : DbContext
    {

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Parent> Parents { get; set; } = null!;

        public DBContext(DbContextOptions<DBContext> options, bool migrate = true) : base(options)
        {
            if (migrate)
                Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).DateUpdated = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).DateAdded = DateTime.Now;
                }
            }

            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new InfrastructureException($"При сохранении в базу данных возникла ошибка. {ex.Message}");
            }

        }

        public override System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).DateUpdated = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).DateAdded = DateTime.Now;
                }
            }
            try
            {
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new InfrastructureException($"При сохранении в базу данных возникла ошибка. {ex.Message}");
            }
            catch (DbUpdateException ex)
            {
                throw new InfrastructureException($"При сохранении в базу данных возникла ошибка. {ex.Message}");
            }
            catch (OperationCanceledException ex)
            {
                throw new InfrastructureException($"При сохранении в базу данных возникла ошибка. {ex.Message}");
            }
        }


    }
}
