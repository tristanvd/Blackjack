using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KillerApp_Casino.Code;

namespace KillerApp_Casino.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult GoToBlackjack()
		{
			Game bjg = new Game();
			return RedirectToAction("Index", "Blackjack", bjg);
		}
    }
}