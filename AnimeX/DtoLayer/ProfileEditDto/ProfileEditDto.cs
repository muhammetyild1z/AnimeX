using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DtoLayer.ProfileEditDto
{
    public class ProfileEditDto
    {
        public string UserName { get; set; }
        public string Details { get; set; }
        public string Email { get; set; }

        public string password { get; set; }
        public string Oldpassword { get; set; }
        public string passwordR { get; set; }
    }
}
