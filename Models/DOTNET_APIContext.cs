using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DOTNET_ANGULAR_API.Models
{
    public partial class DOTNET_APIContext : DbContext
    {
        public DOTNET_APIContext()
        {
        }

        public DOTNET_APIContext(DbContextOptions<DOTNET_APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Register> Registers { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder options)=> options.UseSqlServer("TEConnection");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                  //optionsBuilder.UseSqlServer("Server=ELW5136\\SQLEXPRESS;Database=DOTNET_API;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");

                //entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("useremail");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
