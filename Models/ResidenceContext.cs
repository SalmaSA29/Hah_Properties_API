using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PortalAPI.Models
{
    public partial class ResidenceContext : DbContext
    {
        public ResidenceContext()
        {
        }

        public ResidenceContext(DbContextOptions<ResidenceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<PaymentPlans> PaymentPlans { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<UnitPaymentPlan> UnitPaymentPlan { get; set; }
        public virtual DbSet<Units> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Residence;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buildings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnName("In_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InUser)
                    .IsRequired()
                    .HasColumnName("In_User")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProjId).HasColumnName("Proj_ID");

                entity.Property(e => e.UpDate)
                    .HasColumnName("Up_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpUser)
                    .HasColumnName("Up_User")
                    .IsUnicode(false);

                entity.HasOne(d => d.Proj)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.ProjId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Buildings_Projects");
            });

            modelBuilder.Entity<PaymentPlans>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Plan)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.InDate)
                    .HasColumnName("In_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InUser)
                    .IsRequired()
                    .HasColumnName("In_User")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpDate)
                    .HasColumnName("Up_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpUser)
                    .HasColumnName("Up_User")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuildingsId).HasColumnName("Buildings_ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Hrcode)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.InDate)
                    .HasColumnName("In_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InUser)
                    .IsRequired()
                    .HasColumnName("In_User")
                    .IsUnicode(false);

                entity.Property(e => e.PaymentPlanId).HasColumnName("PaymentPlan_ID");

                entity.Property(e => e.ProjId).HasColumnName("Proj_ID");

                entity.Property(e => e.SharingUsers)
                    .HasColumnName("Sharing_Users")
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.UpDate)
                    .HasColumnName("Up_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpUser)
                    .HasColumnName("Up_User")
                    .IsUnicode(false);

                entity.HasOne(d => d.Buildings)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.BuildingsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Request_Buildings");

                entity.HasOne(d => d.PaymentPlan)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.PaymentPlanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Request_PaymentPlan");

                entity.HasOne(d => d.Proj)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ProjId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Request_Project");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Request_Unit");
            });

            modelBuilder.Entity<UnitPaymentPlan>(entity =>
            {
                entity.HasKey(e => new { e.PaymentPlanId, e.UnitId })
                    .HasName("PK_Composite");

                entity.ToTable("Unit_PaymentPlan");

                entity.Property(e => e.PaymentPlanId).HasColumnName("PaymentPlan_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.HasOne(d => d.PaymentPlan)
                    .WithMany(p => p.UnitPaymentPlan)
                    .HasForeignKey(d => d.PaymentPlanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Unit_PaymentPlan_Payment");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.UnitPaymentPlan)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Unit_PaymentPlan_Unit");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Attach).IsUnicode(false);

                entity.Property(e => e.BuildingsId).HasColumnName("Buildings_ID");

                entity.Property(e => e.InDate)
                    .HasColumnName("In_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InUser)
                    .IsRequired()
                    .HasColumnName("In_User")
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UpDate)
                    .HasColumnName("Up_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpUser)
                    .HasColumnName("Up_User")
                    .IsUnicode(false);

                entity.HasOne(d => d.Buildings)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.BuildingsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Units_Buildings");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
