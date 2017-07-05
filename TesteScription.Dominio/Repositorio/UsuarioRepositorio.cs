using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using TesteScription.Dominio.Modelo;

namespace TesteScription.Dominio.Repositorio
{
    public class UsuarioRepositorio
    {
        private readonly Contexto _contexto = new Contexto();

        public bool ValidarLogin(UsuarioModelo dadosTela)
        {
            var query = (from usuario in _contexto.USUARIOS
                         where usuario.Login == dadosTela.Login &&
                         usuario.Senha == dadosTela.Senha
                         select usuario).SingleOrDefault();

            if(query == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public IEnumerable<UsuarioModelo> GetAll()
        {
            var dadosBanco = _contexto.USUARIOS.ToList();

            return dadosBanco;
        }

        public IEnumerable<UsuarioModelo> GetAll(Expression<Func<UsuarioModelo, bool>> Predicate)
        {
            var dadosBanco = _contexto.USUARIOS.Where(Predicate).ToList();

            return dadosBanco;
        }
    }
}
