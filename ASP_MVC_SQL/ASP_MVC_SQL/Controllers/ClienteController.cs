using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_SQL.Models;

namespace ASP_MVC_SQL.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var clienteColecao = new List<ClienteModel>();

            foreach (var cliente in clienteColecao)
            {
                cliente.Add(new ClienteModel()
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    
                    
                });
            }
                       
           
        
            

            return View(clienteColecao);
        }
    }
}