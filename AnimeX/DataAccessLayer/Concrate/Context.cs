using AnimeX.EntityLayer;
using EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.Concrate
{
    public class Context: IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CH9SD0T;initial catalog=AnimeX; integrated Security=true");
        }
        public DbSet<Animeler> Animelers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoryAnime> CategoryAnimes { get; set; }
        public DbSet<AnimeSezon> animeSezons { get; set; }
        public DbSet<Comments> comments { get; set; }
        public DbSet<Sezons> sezons { get; set; }

    }
}
