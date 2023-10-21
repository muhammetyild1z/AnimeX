using AnimeX.EntityLayer;
using EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.Concrate
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CH9SD0T;initial catalog=AnimeX; integrated Security=true");
        }
        public DbSet<Animeler> Animelers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoryAnime> CategoryAnimes { get; set; }
        public DbSet<Comments> comments { get; set; }
        public DbSet<AnimeSezonlar> animeSezonlars { get; set; }
        public DbSet<AnimeBolums> AnimeBolums { get; set; }
        public DbSet<UserFavori> userFavoris { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<UserFavori>().HasKey(x => new { x.FavAnimeID, x.FavUserId, x.FavoriID });
            modelBuilder.Entity<UserFavori>().HasOne(x => x.Animelers)
                 .WithMany(x => x.userFavoris).HasForeignKey(x => x.FavAnimeID);
            modelBuilder.Entity<UserFavori>().HasOne(x => x.AppUser)
                .WithMany(x => x.userFavoris).HasForeignKey(x => x.FavUserId);


            modelBuilder.Entity<AnimeSezonlar>().HasKey(x => new { x.AnimeID , x.AnimelerSezonId});
            modelBuilder.Entity<AnimeSezonlar>().HasOne(x => x.animeler)
               .WithMany(x => x.animeSezons).HasForeignKey(x => x.AnimeID);

            modelBuilder.Entity<AnimeBolums>().HasKey(x => new { x.BolumAnimeID , x.BolumID});
            modelBuilder.Entity<AnimeBolums>().HasOne(x => x.animeler)
               .WithMany(x => x.animeBolums).HasForeignKey(x => x.BolumAnimeID);

            modelBuilder.Entity<CategoryAnime>().HasKey(x => new { x.AnimeID , x.ID });
            modelBuilder.Entity<CategoryAnime>().HasOne(x => x.animeler)
               .WithMany(x => x.categoryAnimes).HasForeignKey(x => x.AnimeID);

            modelBuilder.Entity<CategoryAnime>().HasKey(x => new { x.KategoriID , x.ID });
            modelBuilder.Entity<CategoryAnime>().HasOne(x => x.categories)
               .WithMany(x => x.categoryAnimes).HasForeignKey(x => x.KategoriID);

            modelBuilder.Entity<Comments>().HasKey(x => new { x.AnimeCommentID, x.CommentID, x.CommentUserId });
            modelBuilder.Entity<Comments>().HasOne(x => x.animeler)
               .WithMany(x => x.comments).HasForeignKey(x => x.AnimeCommentID);
            modelBuilder.Entity<Comments>().HasOne(x => x.appUser)
              .WithMany(x => x.comments).HasForeignKey(x => x.CommentUserId);


            base.OnModelCreating(modelBuilder);
        }

    }
}



