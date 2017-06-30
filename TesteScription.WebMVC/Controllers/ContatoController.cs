using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TesteScription.Dominio.Modelo;
using TesteScription.Dominio.Repositorio;

namespace TesteScription.WebMVC.Controllers
{
    public class ContatoController : Controller
    {
        private ContatoRepositorio dbContato;        

        [Authorize]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(ContatoModelo dadosTela)
        {
            try
            {
                dbContato = new ContatoRepositorio();
                dbContato.Save(dadosTela);

                TempData.Add("Mensagem", "Contato cadastrado com sucesso!");

                return RedirectToAction("Listar");
            }

            catch (Exception erro)
            {

                TempData.Add("Mensagem", "Erro ao cadastrar!");

                return View();
            }
        }

        [Authorize]
        public ActionResult Listar(string buscar)
        {
            dbContato = new ContatoRepositorio();

            if (!string.IsNullOrEmpty(buscar))
            {
                try
                {
                    var contato = new ContatoModelo();
                    var query = dbContato.GetAll(c => c.Nome.ToUpper() == buscar.ToUpper());

                    return View(query);

                }
                catch (Exception erro)
                {

                    TempData.Add("Mensagem", "Contato não localizado!");

                    return View();
                }
            }
            else
            {
                try
                {
                    var contatos = dbContato.GetAll().ToList();

                    return View(contatos);

                }
                catch (Exception erro)
                {

                    TempData.Add("Mensagem", "Erro ao listar!");

                    return View();
                }
            }
        }

        public ActionResult Editar(int id)
        {
            dbContato = new ContatoRepositorio();
            var contato = dbContato.Find(id);

            return View(contato);
        }

        [HttpPost]
        public ActionResult Editar(ContatoModelo contato)
        {
            try
            {
                dbContato = new ContatoRepositorio();
                dbContato.Save(contato);

                return RedirectToAction("Listar");
            }
            catch (Exception)
            {

                TempData.Add("Mensagem", "Erro ao atualizar!");
                return View();
            }
        }

        public ActionResult Deletar(int id)
        {
            dbContato = new ContatoRepositorio();
            var query = dbContato.Find(id);

            dbContato.Delete(query);

            TempData.Add("Mensagem", "Contato excluido com sucesso!");

            return RedirectToAction("Listar");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuarioModelo dadosTela)
        {
            var repositorio = new UsuarioRepositorio();

            if (!repositorio.ValidarLogin(dadosTela))
            {
                TempData.Add("Mensagem", "Usuário ou Senha inválidos");

                return View();
            }
            
            FormsAuthentication.SetAuthCookie(dadosTela.Login, true);

            return RedirectToAction("Listar");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}