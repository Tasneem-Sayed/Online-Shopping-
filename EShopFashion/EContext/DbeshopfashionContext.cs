﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EShopFashion.Entities;

#nullable disable

namespace EShopFashion.EContext
{
    public partial class DbeshopfashionContext : DbContext
    {
        public DbeshopfashionContext()
        {
        }

        public DbeshopfashionContext(DbContextOptions<DbeshopfashionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tb1CartStatus> Tb1CartStatuses { get; set; }
        public virtual DbSet<Tb1Category> Tb1Categories { get; set; }
        public virtual DbSet<Tb1Product> Tb1Products { get; set; }
        public virtual DbSet<TblCart> TblCarts { get; set; }
        public virtual DbSet<TblMember> TblMembers { get; set; }
        public virtual DbSet<TblMemberRole> TblMemberRoles { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblShippingDetail> TblShippingDetails { get; set; }
        public virtual DbSet<TblSlideImage> TblSlideImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-VDKF7S8;Initial Catalog=dbEShopFashion;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Tb1CartStatus>(entity =>
            {
                entity.HasKey(e => e.CartStatusId)
                    .HasName("PK__Tb1_Cart__031908A8723ED6FA");

                entity.ToTable("Tb1_CartStatus");

                entity.Property(e => e.CartStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tb1Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Tb1_Cate__19093A0B846A9DE8");

                entity.ToTable("Tb1_Category");

                entity.HasIndex(e => e.CategoryName, "UQ__Tb1_Cate__8517B2E0EC13E5B2")
                    .IsUnique();

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tb1Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Tb1_Prod__B40CC6CDD553B2C0");

                entity.ToTable("Tb1_Products");

                entity.HasIndex(e => e.ProductName, "UQ__Tb1_Prod__DD5A978AE97A8E5B")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductImage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Tb1Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Tb1_Produ__Categ__286302EC");
            });

            modelBuilder.Entity<TblCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__Tbl_Cart__51BCD7B7A8D3624B");

                entity.ToTable("Tbl_Cart");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblCarts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Tbl_Cart__Produc__36B12243");
            });

            modelBuilder.Entity<TblMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__Tbl_Memb__0CF04B18B0D33E52");

                entity.ToTable("Tbl_Members");

                entity.HasIndex(e => e.LastName, "UQ__Tbl_Memb__7449F399EC22CBEF")
                    .IsUnique();

                entity.HasIndex(e => e.EmailId, "UQ__Tbl_Memb__7ED91ACE4CFB1D1F")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FristName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMemberRole>(entity =>
            {
                entity.HasKey(e => e.MemberRoleId)
                    .HasName("PK__Tbl_Memb__673C22CBC45591CB");

                entity.ToTable("Tbl_MemberRole");

                entity.Property(e => e.MemberRoleId).HasColumnName("MemberRoleID");

                entity.Property(e => e.MemberId).HasColumnName("memberId");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Tbl_Role__8AFACE1A2975CB77");

                entity.ToTable("Tbl_Roles");

                entity.HasIndex(e => e.RoleName, "UQ__Tbl_Role__8A2B616059612B2E")
                    .IsUnique();

                entity.Property(e => e.RoleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShippingDetail>(entity =>
            {
                entity.HasKey(e => e.ShippingDetailId)
                    .HasName("PK__Tbl_Ship__FBB36851223D1A02");

                entity.ToTable("Tbl_ShippingDetails");

                entity.Property(e => e.Adress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.City)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblShippingDetails)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__Tbl_Shipp__Membe__30F848ED");
            });

            modelBuilder.Entity<TblSlideImage>(entity =>
            {
                entity.HasKey(e => e.SlideId)
                    .HasName("PK__Tbl_Slid__9E7CB6508B8F9F9F");

                entity.ToTable("Tbl_SlideImage");

                entity.Property(e => e.SlideImage).IsUnicode(false);

                entity.Property(e => e.SlideTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}