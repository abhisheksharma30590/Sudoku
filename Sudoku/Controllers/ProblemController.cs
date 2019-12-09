using Sudoku.Common.Common;
using Sudoku.Common.Model;
using Sudoku.Common.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sudoku.Controllers
{
    public class ProblemController : Controller
    {
        ProblemService _problemService = new ProblemService();

        public ProblemController()
        {
            Constants.XMlFilePath = System.Web.HttpContext.Current.Server.MapPath(@"~\Data\SudokuProblems.xml");
        }

        // GET: Problem
        public ActionResult Index()
        {
            List<SudokuModel> modelList = new List<SudokuModel>();
            modelList = _problemService.ProblemList();
            return View(modelList);
        }

        [HttpGet]
        public ActionResult AddProblem()
        {
            SudokuModel model = new SudokuModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProblem(SudokuModel model)
        {
            int result = _problemService.AddProblemStatement(model);
            if (result > 0)
                TempData[Constants.SUCCESS_MESSAGE] = "Problem statement creatred successfully";
            else
                TempData[Constants.ERROR_MESSAGE] = "Error while adding problem statement";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Solve(string problemId)
        {
            SudokuModel model = new SudokuModel();
            model = _problemService.GetProblemByProblemId(problemId);
            return View(model);
        }
    }
}