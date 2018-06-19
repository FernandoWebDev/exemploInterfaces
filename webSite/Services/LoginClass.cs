using System;

using webSite.Models;
using liibServicos.Servico;

namespace webSite.Services
{
    public class LoginClass
    {
        public (string mensagem, bool retorno) Login(LoginModel login)
        {
            var logado = new UsuarioClass().loginUsuario<LoginModel>(login);

            if (logado)
                return (mensagem: "Usuario logado com sucesso!", retorno: true);

            return ("Usuário ou senha incorretos. Tente novamente.", retorno: false);
        }
    }
}