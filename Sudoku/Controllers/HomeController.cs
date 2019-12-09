using Sudoku.Common.Common;
using Sudoku.Common.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sudoku.Controllers
{
    public class HomeController : Controller
    {
        ProblemService _problemService = new ProblemService();

        public HomeController()
        {
            Constants.XMlFilePath = System.Web.HttpContext.Current.Server.MapPath(@"~\Data\SudokuProblems.xml");
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Count = _problemService.GetProblemsCount();
            return View();
        }
    }
}