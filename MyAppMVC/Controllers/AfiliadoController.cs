using MyAppMVC.Models;
using MyAppMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAppMVC.Controllers
{
    public class AfiliadoController : Controller
    {
        private IRepository<Afiliado, int> _repository;

        public AfiliadoController(IRepository<Afiliado, int> repo)
        {
            _repository = repo;
        }


        // GET: Afiliado
        public ActionResult Index()
        {
            var afiliados = _repository.Get();

            return View(afiliados);
        }
    }
}