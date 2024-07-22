using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_SQL.CORE.NG;
using ASP_MVC_SQL.Models;

namespace ASP_MVC_SQL.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            //lista de cliente 
            //lista de cliente que venha  DB
            //Camada de apresentção não vai , direto do DB
            //Listar os cliente de camada de Negocio

            var clienteNG = new ClienteNG();
            var clienteColecao = clienteNG.Listar();

            var clienteModelColecao = new List<ClienteModel>();
            foreach (var item in clienteColecao)
            {
                clienteModelColecao.Add(new ClienteModel()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                });
            }

            return View(clienteModelColecao);
        }

        public ActionResult Detalhe()
        {
            return View();
        }

        
    }
}