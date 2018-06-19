using System;

using liibServicos.Interface;

namespace webSite.Models
{
    public class LoginModel : ILogin
    {
        public string Login { get; set; }
        public string Senha { get; set;}
    }
}