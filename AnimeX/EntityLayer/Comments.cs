using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Comments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }      
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }    
        public bool CommentStatus { get; set; }
        public Animeler animeler { get; set; }
        public int AnimeCommentID { get; set; }
        public AppUser appUser { get; set; }
        public int CommentUserId { get; set; }
    }
}
