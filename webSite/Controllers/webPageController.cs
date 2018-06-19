using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using webSite.Models;
using webSite.Services;

namespace webSite.Controllers
{
    public class webPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Logar(LoginModel login)
        {
            var retorno = new LoginClass().Login(login);

            return Json(retorno);
        }
    }
}