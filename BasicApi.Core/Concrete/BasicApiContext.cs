using BasicApi.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Core.Concrete
{
    public partial class BasicApiContext : DbContext
    {
        public BasicApiContext()
        {
        }

        public BasicApiContext(DbContextOptions<BasicApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Paymenttype> Paymenttype { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Saleitem> Saleitem { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=BasicApi;Username=postgres;Password=159753");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("customer_UserId_fkey");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("product_UserId_fkey");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("sale_UserId_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
