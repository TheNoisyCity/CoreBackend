using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreBackend.Model
{
    public partial class noisycityContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=myaibig1.mysql.rds.aliyuncs.com;Database=noisycity;User ID=ncbackend;Password=Jft23333;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("user");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AvatarPath)
                    .HasColumnName("avatar_path")
                    .HasMaxLength(64);

                entity.Property(e => e.Bio)
                    .HasColumnName("bio")
                    .HasMaxLength(512);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(64);

                entity.Property(e => e.EmailConfirmed)
                    .HasColumnName("email_confirmed")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.LanguageFirst)
                    .HasColumnName("language_first")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.LanguageSecond)
                    .HasColumnName("language_second")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.LastTimeUsernameChanged)
                    .HasColumnName("last_time_username_changed")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(128);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(16);

                entity.Property(e => e.PhoneConfirmed)
                    .HasColumnName("phone_confirmed")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(64);
            });
        }
    }
}
