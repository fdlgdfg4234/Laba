using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhoneMaster
{
    public partial class HelpContext : DbContext
    {
        public HelpContext()
        {
        }

        public HelpContext(DbContextOptions<HelpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adress> Adresses { get; set; } = null!;
        public virtual DbSet<Card> Cards { get; set; } = null!;
        public virtual DbSet<Delivery> Deliveries { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Phone> Phones { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserList> UserLists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Help;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adress>(entity =>
            {
                entity.HasKey(e => e.Idadress);

                entity.ToTable("Adress");

                entity.Property(e => e.Idadress).HasColumnName("IDAdress");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Flat)
                    .HasMaxLength(100)
                    .HasColumnName("flat");

                entity.Property(e => e.House).HasMaxLength(100);

                entity.Property(e => e.Street).HasMaxLength(100);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => e.Idcard);

                entity.ToTable("card");

                entity.Property(e => e.Idcard).HasColumnName("IDcard");

                entity.Property(e => e.Cvv)
                    .HasMaxLength(3)
                    .HasColumnName("CVV");

                entity.Property(e => e.NameOfOwner).HasMaxLength(50);

                entity.Property(e => e.NumberOfCard).HasMaxLength(50);

                entity.Property(e => e.ValidityPeriod).HasColumnType("date");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasKey(e => e.Iddelivery);

                entity.ToTable("delivery");

                entity.Property(e => e.Iddelivery).HasColumnName("IDdelivery");

                entity.Property(e => e.Idadress).HasColumnName("IDAdress");

                entity.Property(e => e.Idpayment).HasColumnName("IDpayment");

                entity.HasOne(d => d.IdadressNavigation)
                    .WithMany(p => p.Deliveries)
                    .HasForeignKey(d => d.Idadress)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_delivery_Adress1");

                entity.HasOne(d => d.IdpaymentNavigation)
                    .WithMany(p => p.Deliveries)
                    .HasForeignKey(d => d.Idpayment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_delivery_Payment");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.Idmodel);

                entity.ToTable("Model");

                entity.Property(e => e.Idmodel).HasColumnName("IDmodel");

                entity.Property(e => e.Manufacturer).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Idorder);

                entity.ToTable("Order");

                entity.Property(e => e.Idorder)
                    .ValueGeneratedNever()
                    .HasColumnName("IDorder");

                entity.Property(e => e.Iddelivery).HasColumnName("IDdelivery");

                entity.Property(e => e.Idmaster).HasColumnName("IDmaster");

                entity.Property(e => e.Idphone)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDphone");

                entity.Property(e => e.Idstatus).HasColumnName("IDstatus");

                entity.HasOne(d => d.IddeliveryNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Iddelivery)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_delivery");

                entity.HasOne(d => d.IdphoneNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Idphone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Phone");

                entity.HasOne(d => d.IdstatusNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Idstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Status");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.Idpayment);

                entity.ToTable("Payment");

                entity.Property(e => e.Idpayment)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPayment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Idcard).HasColumnName("IDcard");

                entity.HasOne(d => d.IdcardNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Idcard)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_card");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasKey(e => e.Idphone);

                entity.ToTable("Phone");

                entity.Property(e => e.Idphone).HasColumnName("IDPhone");

                entity.Property(e => e.Idmodel).HasColumnName("IDModel");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI");

                entity.HasOne(d => d.IdmodelNavigation)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.Idmodel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phone_Model");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Idrole)
                    .HasName("PK_Таблица2");

                entity.ToTable("Role");

                entity.Property(e => e.Idrole).HasColumnName("IDRole");

                entity.Property(e => e.NameOfRole).HasMaxLength(10);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Idstatus);

                entity.ToTable("Status");

                entity.Property(e => e.Idstatus).HasColumnName("IDstatus");

                entity.Property(e => e.OrderName).HasMaxLength(100);

                entity.Property(e => e.OrderStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Iduser);

                entity.ToTable("User");

                entity.Property(e => e.Iduser)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDUser");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(10)
                    .HasColumnName("telephoneNumber");

                //entity.HasOne(d => d.IduserNavigation)
                //    .WithOne(p => p.User)
                //    .HasForeignKey<User>(d => d.Iduser)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<UserList>(entity =>
            {
                entity.HasKey(e => e.IduserList);

                entity.ToTable("UserList");

                entity.Property(e => e.IduserList).HasColumnName("IDUserList");

                entity.Property(e => e.Idorder).HasColumnName("IDOrder");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.HasOne(d => d.IdorderNavigation)
                    .WithMany(p => p.UserLists)
                    .HasForeignKey(d => d.Idorder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserList_Order");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.UserLists)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserList_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
