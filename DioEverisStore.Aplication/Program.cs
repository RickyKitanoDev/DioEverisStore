using DioEverisStore.Domain;
using System;

namespace DioEverisStore.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Teste Usuario e perfil
                Perfil perfil = new Perfil
                {
                    Id = 1,
                    Descricao = "Administrador",
                    Regra = "Pode acessar tudo",
                    DataCadastro = DateTime.Now,
                    Ativo = true
                };

                Usuario usuario = new Usuario(1, "Ricky", "ricky@gmail.com", "123", 1);
                usuario.Perfil = perfil;
                var usuarioPerfil = usuario.Perfil;

                string nomePerfil = usuarioPerfil.Descricao;


                var verificaAtivo = usuario.RetornarAtivo();

                usuario.Desativar();
                usuario.Desativar(0);
                var verificaAtivo2 = usuario.RetornarAtivo();

                usuario.Ativar();
                var verificaAtivo3 = usuario.RetornarAtivo();

                // Teste produto
                Produto produto = new Produto(1, "Mesa", "Mesa escritório MDF", 200.00M, 5);

                produto.ReporEstoque(15);

                var possuiEstoque = produto.PossuiEstoque(10);
                if (possuiEstoque)
                    produto.DebitarEstoque(10);

                var possuiEstoque2 = produto.PossuiEstoque(15);
                if (possuiEstoque2)
                    produto.DebitarEstoque(10);
            }
        }
    }
}
