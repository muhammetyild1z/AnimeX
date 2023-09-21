using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Comments
    {
        [Key]
        public int CommentID { get; set; }
        public string UserImg { get; set; }
        public string UserName { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int AnimeCommentID { get; set; }
        public Animeler animeler { get; set; }
    }
}
