using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreBackend.Models
{
    public partial class MySqlContext : DbContext
    {
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Hark> Hark { get; set; }
        public virtual DbSet<Like> Like { get; set; }
        public virtual DbSet<Medal> Medal { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
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
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("comment");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommenterUser)
                    .HasColumnName("commenter_user")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ReplyToComment)
                    .HasColumnName("reply to comment")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ReplyToUser)
                    .HasColumnName("reply_to_user")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Hark>(entity =>
            {
                entity.HasKey(e => new { e.ListenerId, e.ListeneeId, e.Rid });

                entity.ToTable("hark");

                entity.Property(e => e.ListenerId)
                    .HasColumnName("listener_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ListeneeId)
                    .HasColumnName("listenee_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.HasKey(e => new { e.Rid, e.Uid });

                entity.ToTable("like");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Medal>(entity =>
            {
                entity.ToTable("medal");

                entity.Property(e => e.MedalId)
                    .HasColumnName("medalId")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AwardTime)
                    .HasColumnName("award_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(128);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(16);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.Mid);

                entity.ToTable("message");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(2048);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(64);

                entity.Property(e => e.IsRead)
                    .HasColumnName("is read")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("receiver_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SenderId)
                    .HasColumnName("sender_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("record");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("create_user")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(512);

                entity.Property(e => e.DialectX).HasColumnName("dialect_x");

                entity.Property(e => e.DialectY).HasColumnName("dialect_y");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(64);

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.UploadPositionX).HasColumnName("upload_position_x");

                entity.Property(e => e.UploadPositionY).HasColumnName("upload_position_y");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("report");

                entity.Property(e => e.Reportid)
                    .HasColumnName("reportid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(32);

                entity.Property(e => e.ReportTime)
                    .HasColumnName("report_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Reportee)
                    .HasColumnName("reportee")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Reporter)
                    .HasColumnName("reporter")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tagId")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.TagType)
                    .HasColumnName("tag_type")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(16);
            });

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
                    .HasMaxLength(128);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DialectFirstX).HasColumnName("dialect_first_x");

                entity.Property(e => e.DialectFirstY).HasColumnName("dialect_first_y");

                entity.Property(e => e.DialectSecondX).HasColumnName("dialect_second_x");

                entity.Property(e => e.DialectSecondY).HasColumnName("dialect_second_y");

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
                    .HasMaxLength(32);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(16);

                entity.Property(e => e.PhoneConfirmed)
                    .HasColumnName("phone_confirmed")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(16);
            });
        }
    }
}
