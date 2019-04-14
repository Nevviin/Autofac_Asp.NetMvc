using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_RepositoryAutoFac.Models;
using MVC_RepositoryAutoFac.Repositories;

namespace MVC_RepositoryAutoFac.Controllers
{
    public class HomeController : Controller
    {
        IRepository _iRepository;

        public HomeController(IRepository iRepository)
        {
            _iRepository = iRepository;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var company = _iRepository.GetCompany();


            return View(company);
        }

    }
}
