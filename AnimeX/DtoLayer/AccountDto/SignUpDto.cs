using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DtoLayer.AccountDto
{
    public class SignUpDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordR { get; set; }
        public string UserName { get; set; }
    }
}
