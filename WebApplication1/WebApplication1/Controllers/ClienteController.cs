using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using ClassLibrary2.Entity;


namespace WebApplication1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Criar
        public ActionResult Index()
        {
            return View();


        }

        public ActionResult Create()
        {
            return View(new ClienteModel());
        }

        public ActionResult Create(ClienteModel clienteModel)
        {



            var clienteEntity = new ClienteEntity()
            {
                Id = clienteModel.Id,
                Name = clienteModel.Name,
            };
            return RedirectToAction("Index");

        }


    }
}