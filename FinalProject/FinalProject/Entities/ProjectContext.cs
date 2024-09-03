using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProject
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cpu> Cpus { get; set; }
        public virtual DbSet<MotherBoard> MotherBoards { get; set; }
        public virtual DbSet<PurchaseHistory> PurchaseHistories { get; set; }
        public virtual DbSet<Ram> Rams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VideoCard> VideoCards { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(20);
                entity.Property(e => e.Category1).HasMaxLength(20).HasColumnName("Category");
            });

            modelBuilder.Entity<Cpu>(entity =>
            {
                entity.ToTable("CPUs");
                entity.Property(e => e.Brand).HasMaxLength(10);
                entity.Property(e => e.ClockSpeed).HasMaxLength(50);
                entity.Property(e => e.Model).HasMaxLength(50);
                entity.Property(e => e.Stock).HasColumnName("stock");
                entity.Property(e => e.Price).HasColumnName("price").HasColumnType("decimal(18,2)"); // Update column type
            });

            modelBuilder.Entity<MotherBoard>(entity =>
            {
                entity.Property(e => e.Brand).HasMaxLength(50);
                entity.Property(e => e.Model).HasMaxLength(50);
                entity.Property(e => e.Ram).HasMaxLength(50).HasColumnName("RAM");
                entity.Property(e => e.Socket).HasMaxLength(50);
                entity.Property(e => e.Stock).HasColumnName("stock");
                entity.Property(e => e.Price).HasColumnName("price").HasColumnType("decimal(18,2)"); // Update column type
            });

            modelBuilder.Entity<PurchaseHistory>(entity =>
            {
                entity.ToTable("PurchaseHistory");
                entity.Property(e => e.Brand).HasMaxLength(20);
                entity.Property(e => e.Category).HasMaxLength(20);
                entity.Property(e => e.Model).HasMaxLength(20);
            });

            modelBuilder.Entity<Ram>(entity =>
            {
                entity.ToTable("RAMs");
                entity.Property(e => e.Brand).HasMaxLength(50);
                entity.Property(e => e.Model).HasMaxLength(10).IsFixedLength();
                entity.Property(e => e.Stock).HasColumnName("stock");
                entity.Property(e => e.Price).HasColumnName("price").HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.PasswordHash).HasMaxLength(200);
                entity.Property(e => e.PasswordSalt).HasMaxLength(200);
                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<VideoCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_VideoCards");
                entity.Property(e => e.Brand).HasMaxLength(50);
                entity.Property(e => e.MemoryType).HasMaxLength(10).IsUnicode(false);
                entity.Property(e => e.Model).HasMaxLength(50);
                entity.Property(e => e.Price).HasColumnName("price").HasColumnType("decimal(18,2)"); // Update column type
                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Roles");
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId }).HasName("PK_UserRoles");

                entity.HasOne<User>(ur => ur.User)
                    .WithMany(u => u.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                entity.HasOne<Role>(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
