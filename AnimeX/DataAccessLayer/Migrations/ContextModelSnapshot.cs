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

                    b.Property<DateTime>("AnimeEklenmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("AnimeKisaDetay")
                        .IsRequired()
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
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AnimeID1")
                        .HasColumnType("int");

                    b.Property<int>("kategoriID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnimeID1");

                    b.HasIndex("kategoriID");

                    b.ToTable("CategoryAnimes");
                });

            modelBuilder.Entity("EntityLayer.CategoryAnime", b =>
                {
                    b.HasOne("EntityLayer.Animeler", "AnimeID")
                        .WithMany("categoryAnimes")
                        .HasForeignKey("AnimeID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Categories", "KategoriID")
                        .WithMany("categoryAnimes")
                        .HasForeignKey("kategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimeID");

                    b.Navigation("KategoriID");
                });

            modelBuilder.Entity("EntityLayer.Animeler", b =>
                {
                    b.Navigation("categoryAnimes");
                });

            modelBuilder.Entity("EntityLayer.Categories", b =>
                {
                    b.Navigation("categoryAnimes");
                });
#pragma warning restore 612, 618
        }
    }
}
