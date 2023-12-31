﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserFavori
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavoriID { get; set; }
        public int FavAnimeID { get; set; }
        public virtual Animeler Animelers { get; set; }
        public int FavUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public DateTime FavDate { get; set; }
    }
}
