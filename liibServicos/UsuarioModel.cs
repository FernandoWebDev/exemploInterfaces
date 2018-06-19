using System;
using System.Collections.Generic;

namespace liibServicos.Model
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public List<Usuario_Contas> Contas { get; set; }

        public Usuario obtemUsuarioTeste()
        {
            return new Usuario() {
                Id = 1,
                Nome = "Fernando",
                Sobrenome = "Pereira",
                Sexo = "Masculino",
                Idade = 30,
                Contas = new List<Usuario_Contas>() { 
                    new Usuario_Contas() {
                        Usuario_Id = 1,
                        Login = "fpereira",
                        Senha = "123456"
                    }
                }
            };
        }
    }

    internal class Usuario_Contas
    {
        public int Usuario_Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }        
    }
}
