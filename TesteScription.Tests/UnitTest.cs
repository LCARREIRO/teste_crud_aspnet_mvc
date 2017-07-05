using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TesteScription.Dominio.Repositorio;
using TesteScription.Dominio.Modelo;

namespace TesteScription.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CriarUsuarioNoBanco()
        {
            var _contexto = new Contexto();

            var usuario = new UsuarioModelo();
            usuario.Login = "admin";
            usuario.Senha = "123";

            _contexto.USUARIOS.Add(usuario);
            _contexto.SaveChanges();

        }

        [TestMethod]
        public void CriarContatoNoBanco()
        {
            var _contexto = new Contexto();

            var novoContato = new ContatoModelo()
            {
                Nome = "Luciano",
                Telefone = "11997628553",
                Email = "luciano2911@gmail.com"
            };

            _contexto.CONTATOS.Add(novoContato);
            _contexto.SaveChanges();
        }
    }
}
