﻿using AppBancoDLL;
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

        //CLIENTE

        public ActionResult CadastrarCli()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarCli(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var metodoCliente = new ClienteDAO();
                metodoCliente.Insert(cliente);
                return RedirectToAction("ClientesCadastrados");
            }
            return View(cliente);
        }
        public ActionResult ClientesCadastrados()
        {
            var metodoCliente = new ClienteDAO();
            var todosClientes = metodoCliente.Listar();
            return View(todosClientes);
        }
        public ActionResult EditarCli(int id)
        {
            var metodoCliente = new ClienteDAO();
            var clientes = metodoCliente.ListarId(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }
        [HttpPost]
        public ActionResult EditarCli(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var metodoCliente = new ClienteDAO();
                metodoCliente.Atualizar(cliente);
                return RedirectToAction("ClientesCadastrados");
            }
            return View(cliente);
        }
        public ActionResult DetalhesCli(int id)
        {
            var metodoCliente = new ClienteDAO();
            var cliente = metodoCliente.ListarId(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }
        public ActionResult ExcluirCli(int id)
        {
            var metodoCliente = new ClienteDAO();
            var cliente = metodoCliente.ListarId(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }
        [HttpPost, ActionName("ExcluirCli")]
        public ActionResult ExcluirCliConf(int id)
        {
            var metodoCliente = new ClienteDAO();
            Cliente cliente = new Cliente();
            cliente.id_cli = id;
            metodoCliente.Excluir(cliente);
            return RedirectToAction("ClientesCadastrados");
        }

        //PRODUTOS

        public ActionResult CadastrarProd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarProd(Produto produto)
        {
            if (ModelState.IsValid)
            {
                var metodoProduto = new ProdutoDAO();
                metodoProduto.Insert(produto);
                return RedirectToAction("ProdCadastrados");
            }
            return View(produto);
        }
        public ActionResult ProdCadastrados()
        {
            var metodoProduto = new ProdutoDAO();
            var todosProdutos = metodoProduto.Listar();
            return View(todosProdutos);
        }
        public ActionResult EditarProd(int id)
        {
            var metodoProduto = new ProdutoDAO();
            var produtos = metodoProduto.ListarId(id);
            if (produtos == null)
            {
                return HttpNotFound();
            }
            return View(produtos);
        }
        [HttpPost]
        public ActionResult EditarProd(Produto produto)
        {
            if (ModelState.IsValid)
            {
                var metodoProduto = new ProdutoDAO();
                metodoProduto.Atualizar(produto);
                return RedirectToAction("ProdCadastrados");
            }
            return View(produto);
        }
        public ActionResult DetalhesProd(int id)
        {
            var metodoProduto = new ProdutoDAO();
            var produto = metodoProduto.ListarId(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }
        public ActionResult ExcluirProd(int id)
        {
            var metodoProduto = new ProdutoDAO();
            var produto = metodoProduto.ListarId(id);

            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }
        [HttpPost, ActionName("ExcluirProd")]
        public ActionResult ExcluirProdConf(int id)
        {
            var metodoProduto = new ProdutoDAO();
            Produto produto = new Produto();
            produto.id_prod = id;
            metodoProduto.Excluir(produto);
            return RedirectToAction("ProdCadastrados");
        }
        public ActionResult RelatorioVen()
        {
            return View();
        }
        public ActionResult Servicos()
        {
            return View();
        }
        public ActionResult CadastrarConsul()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarConsul(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                var metodoConsulta = new ConsultaDAO();
                metodoConsulta.Insert(consulta);
                return RedirectToAction("ConsulCadastrados");
            }
            return View(consulta);
        }
        public ActionResult ConsulCadastrados()
        {
            var metodoConsulta = new ConsultaDAO();
            var todosConsultas = metodoConsulta.Listar();
            return View(todosConsultas);
        }
    }
}