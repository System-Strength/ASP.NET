using AppBancoDLL;
using AppBancoDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PalacePetz.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VerificaGer()
        {
            return View();
        }
        public ActionResult CadastrarFunc()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarFunc(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                var metodoFuncionario = new FuncionarioDAO();
                metodoFuncionario.Insert(funcionario);
                return RedirectToAction("FuncCadastrados");
            }
            return View(funcionario);
        }
        public ActionResult FuncCadastrados()
        {
            var metodoFuncionario = new FuncionarioDAO();
            var todosFuncionarios = metodoFuncionario.Listar();
            return View(todosFuncionarios);
        }
        public ActionResult EditarFunc(int id)
        {
            var metodoFuncionario = new FuncionarioDAO();
            var funcionarios = metodoFuncionario.ListarId(id);
            if(funcionarios == null)
            {
                return HttpNotFound();
            }
            return View(funcionarios);
        }
        [HttpPost]
        public ActionResult EditarFunc(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                var metodoFuncionario = new FuncionarioDAO();
                metodoFuncionario.Atualizar(funcionario);
                return RedirectToAction("FuncCadastrados");
            }
            return View(funcionario);
        }
        public ActionResult DetalhesFunc(int id)
        {
            var metodoFuncionario = new FuncionarioDAO();
            var funcionario = metodoFuncionario.ListarId(id);
            if(funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }
        public ActionResult ExcluirFunc(int id)
        {
            var metodoFuncionario = new FuncionarioDAO();
            var funcionario = metodoFuncionario.ListarId(id);

            if(funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }
        [HttpPost, ActionName("ExcluirFunc")]
        public ActionResult ExcluirFuncConf(int id)
        {
            var metodoFuncionario = new FuncionarioDAO();
            Funcionario funcionario = new Funcionario();
            funcionario.id_func = id;
            metodoFuncionario.Excluir(funcionario);
            return RedirectToAction("FuncCadastrados");
        }
    }
}