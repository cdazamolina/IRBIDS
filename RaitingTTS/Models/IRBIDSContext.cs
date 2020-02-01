using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RaitingTTS.Models
{
    public partial class IRBIDSContext : DbContext
    {
        public IRBIDSContext()
        {
        }

        public IRBIDSContext(DbContextOptions<IRBIDSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attempt> Attempt { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Word> Word { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=IRBIDS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Attempt>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.WordId);

                entity.Property(e => e.RecordedUrl).HasMaxLength(200);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Attempt)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Word)
                    .WithMany(p => p.Attempt)
                    .HasForeignKey(d => d.WordId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Ani)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Word>(entity =>
            {
                entity.Property(e => e.AudioUrl)
                    .IsRequired()
                    .HasColumnName("AudioURL")
                    .HasMaxLength(200);

                entity.Property(e => e.Language).IsRequired();

                entity.Property(e => e.TextEnglish)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TextSpanish)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
