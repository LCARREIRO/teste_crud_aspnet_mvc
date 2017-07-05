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
        private readonly Contexto _contexto = new Contexto();

        public IEnumerable<ContatoModelo> ObterTodos()
        {
            var dadosBanco = _contexto.CONTATOS.ToList();

            return dadosBanco;
        }

        public IEnumerable<ContatoModelo> ObterTodos(Expression<Func<ContatoModelo, bool>> Predicate)
        {
            var dadosBanco = _contexto.CONTATOS.Where(Predicate).ToList();

            return dadosBanco;
        }
       
        
        public ContatoModelo Buscar(int id)
        {
            var dadosBanco = _contexto.CONTATOS.Find(id);

            return dadosBanco;
        }


        public void Salvar(ContatoModelo contato)
        {
            var contatoMod = new ContatoModelo();

            if (contato.ID == 0)
            {
                _contexto.CONTATOS.Add(contato);
            }
            else
            {
                contatoMod = _contexto.CONTATOS.Find(contato.ID);

                contatoMod.Nome = contato.Nome;
                contatoMod.Telefone = contato.Telefone;
                contatoMod.Email = contato.Email;
            }
            _contexto.SaveChanges();
        }

        public void Excluir(ContatoModelo contato)
        {
            _contexto.CONTATOS.Remove(contato);
            _contexto.SaveChanges();
        }
    }
}
