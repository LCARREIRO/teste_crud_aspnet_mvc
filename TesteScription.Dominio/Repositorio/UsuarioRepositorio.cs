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
        private readonly EfDbContexto _contexto = new EfDbContexto();

        public bool ValidarLogin(UsuarioModelo dadosTela)
        {
            bool login;

            return login = true;
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
