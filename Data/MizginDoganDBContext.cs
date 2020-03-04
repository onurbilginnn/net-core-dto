using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mizgindogancom.Models;

namespace mizgindogancom.Data
{
    public partial class MizginDoganDBContext : DbContext
    {
        public MizginDoganDBContext()
        {
        }

        public MizginDoganDBContext(DbContextOptions<MizginDoganDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TComment> TComment { get; set; }
        public virtual DbSet<TEntry> TEntry { get; set; }
        public virtual DbSet<TInfo> TInfo { get; set; }
        public virtual DbSet<TReply> TReply { get; set; }
        public virtual DbSet<TImage> TImage { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<TComment>(entity =>
            {
                entity.ToTable("T_Comment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.TComment)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK_T_Comment_T_Entry1");
            });

            modelBuilder.Entity<TEntry>(entity =>
            {
                entity.ToTable("T_Entry");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArchiveDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(substring(CONVERT([varchar](11),[Date],(113)),(4),(8)))");

                entity.Property(e => e.Category).HasMaxLength(500);

                entity.Property(e => e.Date).HasColumnType("date");
                entity.Property(e => e.EntrySummary).HasColumnName("Entry_Summary");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.ImageUrlLarge).HasColumnName("ImageURL_Large");
                entity.Property(e => e.ImageUrlMed).HasColumnName("ImageURL_Med");
                entity.Property(e => e.ImageUrlSmall).HasColumnName("ImageURL_Small");
                entity.Property(e => e.Tags).HasColumnName("Tags");

                entity.Property(e => e.PostedBy).HasMaxLength(500);
            });

            modelBuilder.Entity<TInfo>(entity =>
            {
                entity.ToTable("T_Info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress1).HasColumnName("Adress-1");

                entity.Property(e => e.Adress2).HasColumnName("Adress-2");

                entity.Property(e => e.ClosingTime)
                    .HasColumnName("Closing Time")
                    .HasMaxLength(50);

                entity.Property(e => e.Mail1)
                    .HasColumnName("Mail-1")
                    .HasMaxLength(500);

                entity.Property(e => e.Mail2)
                    .HasColumnName("Mail-2")
                    .HasMaxLength(500);

                entity.Property(e => e.MailPassword1)
                    .HasColumnName("MailPassword-1")
                    .HasMaxLength(500);

                entity.Property(e => e.MailPassword2)
                    .HasColumnName("MailPassword-2")
                    .HasMaxLength(500);

                entity.Property(e => e.OpeningTime)
                    .HasColumnName("Opening Time")
                    .HasMaxLength(50);

                entity.Property(e => e.Tel1)
                    .HasColumnName("Tel-1")
                    .HasMaxLength(50);

                entity.Property(e => e.Tel2)
                    .HasColumnName("Tel-2")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TReply>(entity =>
            {
                entity.ToTable("T_Reply");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.TReply)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_T_Reply_T_Comment1");
            });

            modelBuilder.Entity<TImage>(entity =>
            {
                entity.ToTable("T_Image");
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.LocationPage).HasColumnName("Location_Page").HasMaxLength(500); 
                entity.Property(e => e.Name).HasColumnName("Name");
                entity.Property(e => e.Url).HasColumnName("Url");
            });
        }
    }
}
