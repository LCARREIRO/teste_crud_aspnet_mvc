using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using TesteScription.Dominio.Modelo;


namespace TesteScription.Dominio.Repositorio
{
    public class ContatoRepositorio
    {
        private readonly EfDbContexto _contexto = new EfDbContexto();

        public IEnumerable<ContatoModelo> GetAll()
        {
            var dadosBanco = _contexto.CONTATOS.ToList();

            return dadosBanco;
        }

        public IEnumerable<ContatoModelo> GetAll(Expression<Func<ContatoModelo, bool>> Predicate)
        {
            var dadosBanco = _contexto.CONTATOS.Where(Predicate).ToList();

            return dadosBanco;
        }
       
        
        public ContatoModelo Find(int id)
        {
            var dadosBanco = _contexto.CONTATOS.Find(id);

            return dadosBanco;
        }


        public void Save(ContatoModelo contato)
        {
            if (contato.ID == 0)
            {
                _contexto.CONTATOS.Add(contato);
            }
            else
            {
                ContatoModelo contatoMod = _contexto.CONTATOS.Find(contato.ID);

                contatoMod.Nome = contato.Nome;
                contatoMod.Telefone = contato.Telefone;
                contatoMod.Email = contato.Email;
            }
            _contexto.SaveChanges();
        }

        public void Delete(ContatoModelo contato)
        {
            _contexto.CONTATOS.Remove(contato);
            _contexto.SaveChanges();
        }
    }
}
