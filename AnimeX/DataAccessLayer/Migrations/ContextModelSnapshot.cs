﻿// <auto-generated />
using System;
using AnimeX.DataAccessLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.AnimeBolums", b =>
                {
                    b.Property<int>("BolumAnimeID")
                        .HasColumnType("int");

                    b.Property<int>("BolumID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BolumCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BolumNo")
                        .HasColumnType("int");

                    b.Property<string>("BolumUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SezonsNo")
                        .HasColumnType("int");

                    b.HasKey("BolumAnimeID", "BolumID");

                    b.ToTable("AnimeBolums");
                });

            modelBuilder.Entity("EntityLayer.Animeler", b =>
                {
                    b.Property<int>("AnimeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimeID"), 1L, 1);

                    b.Property<string>("AnimeAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AnimeCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("AnimeDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AnimeEklenmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("AnimeImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimeKapakImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimeKisaDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimeUyarlamasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMDb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("AnimeID");

                    b.ToTable("Animelers");
                });

            modelBuilder.Entity("EntityLayer.AnimeSezonlar", b =>
                {
                    b.Property<int>("AnimeID")
                        .HasColumnType("int");

                    b.Property<int>("AnimelerSezonId")
                        .HasColumnType("int");

                    b.Property<int>("SezonNo")
                        .HasColumnType("int");

                    b.HasKey("AnimeID", "AnimelerSezonId");

                    b.ToTable("animeSezonlars");
                });

            modelBuilder.Entity("EntityLayer.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("EntityLayer.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("EmailHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UserCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Categories", b =>
                {
                    b.Property<int>("kategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("kategoriID"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("kategoriID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.CategoryAnime", b =>
                {
                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AnimeID")
                        .HasColumnType("int");

                    b.HasKey("KategoriID", "ID");

                    b.HasIndex("AnimeID");

                    b.ToTable("CategoryAnimes");
                });

            modelBuilder.Entity("EntityLayer.Comments", b =>
                {
                    b.Property<int>("AnimeCommentID")
                        .HasColumnType("int");

                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"), 1L, 1);

                    b.Property<int>("CommentUserId")
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.HasKey("AnimeCommentID", "CommentID", "CommentUserId");

                    b.HasIndex("CommentUserId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("EntityLayer.UserFavori", b =>
                {
                    b.Property<int>("FavAnimeID")
                        .HasColumnType("int");

                    b.Property<int>("FavUserId")
                        .HasColumnType("int");

                    b.Property<int>("FavoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriID"), 1L, 1);

                    b.Property<DateTime>("FavDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FavAnimeID", "FavUserId", "FavoriID");

                    b.HasIndex("FavUserId");

                    b.ToTable("userFavoris");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EntityLayer.AnimeBolums", b =>
                {
                    b.HasOne("EntityLayer.Animeler", "animeler")
                        .WithMany("animeBolums")
                        .HasForeignKey("BolumAnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("animeler");
                });

            modelBuilder.Entity("EntityLayer.AnimeSezonlar", b =>
                {
                    b.HasOne("EntityLayer.Animeler", "animeler")
                        .WithMany("animeSezons")
                        .HasForeignKey("AnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("animeler");
                });

            modelBuilder.Entity("EntityLayer.CategoryAnime", b =>
                {
                    b.HasOne("EntityLayer.Animeler", "animeler")
                        .WithMany("categoryAnimes")
                        .HasForeignKey("AnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Categories", "categories")
                        .WithMany("categoryAnimes")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("animeler");

                    b.Navigation("categories");
                });

            modelBuilder.Entity("EntityLayer.Comments", b =>
                {
                    b.HasOne("EntityLayer.Animeler", "animeler")
                        .WithMany("comments")
                        .HasForeignKey("AnimeCommentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.AppUser", "appUser")
                        .WithMany("comments")
                        .HasForeignKey("CommentUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("animeler");

                    b.Navigation("appUser");
                });

            modelBuilder.Entity("EntityLayer.UserFavori", b =>
                {
                    b.HasOne("EntityLayer.Animeler", "Animelers")
                        .WithMany("userFavoris")
                        .HasForeignKey("FavAnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.AppUser", "AppUser")
                        .WithMany("userFavoris")
                        .HasForeignKey("FavUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animelers");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EntityLayer.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EntityLayer.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EntityLayer.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Animeler", b =>
                {
                    b.Navigation("animeBolums");

                    b.Navigation("animeSezons");

                    b.Navigation("categoryAnimes");

                    b.Navigation("comments");

                    b.Navigation("userFavoris");
                });

            modelBuilder.Entity("EntityLayer.AppUser", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("userFavoris");
                });

            modelBuilder.Entity("EntityLayer.Categories", b =>
                {
                    b.Navigation("categoryAnimes");
                });
#pragma warning restore 612, 618
        }
    }
}
