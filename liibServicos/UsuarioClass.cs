using System;
using System.Linq;
using liibServicos.Interface;
using liibServicos.Model;

namespace liibServicos.Servico
{
    public class UsuarioClass
    {
        public bool loginUsuario<T>(T login) where T : ILogin
        {
            var retorno = new Usuario().obtemUsuarioTeste().Contas.Where(x => x.Login == login.Login && x.Senha == login.Senha).FirstOrDefault();

            if (retorno != null)
                return true;

            return false;
        }
    }
}