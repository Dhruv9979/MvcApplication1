using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }






        [HttpPost]
        public ActionResult Index(User user)
        {

            MVCTestEntities _entity = new MVCTestEntities();

           var _result =  _entity.Users.Select(x => x.Email == user.Email && x.Pws == user.Pws).ToList();

           if (_result[0])
           {
               return RedirectToAction("Index", "Shopping");

           }
           else
           {

               return View();
           }
        }


    }
}
