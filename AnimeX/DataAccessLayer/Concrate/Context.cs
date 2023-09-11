using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.Concrate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CH9SD0T;initial catalog=AnimeX; integrated Security=true");
        }
        public DbSet<Animeler> Animelers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoryAnime> CategoryAnimes { get; set; }

        
    }
}
