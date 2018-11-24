using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hack.Models;

namespace Hack.Controllers
{
    public class HomeController : Controller
    {
        public Context db;
        public HomeController()
        {
         db = new Context();
        }
        public ActionResult Index()
        {
            
            var surfaces = db.Surfaces;
            var spots = db.Spots;
            SelectList spotsSelectList = new SelectList(spots,"Id","Name");
            SelectList surfacesSelectList = new SelectList(surfaces, "Id", "Name");
            ViewModel viewModel = new ViewModel
            {
                spots = spotsSelectList,
                surfaces = surfacesSelectList
            };
            ViewBag.Spots = spotsSelectList;
            ViewBag.Surfaces = surfacesSelectList;
           
            return View(viewModel);
        }
        //public ActionResult ShowResult(int? spotId = null,int? surfaceId = null)
        //{
        //    var answer = db.Options.Where(opt => opt.SpotId == spotId.Value && opt.SurfaceId == surfaceId.Value).FirstOrDefault();
        //    ViewBag.ans = answer.Description;
        //    return View();
        //}
        public ActionResult ShowResult(ViewModel viewModel)
        {
            var answer = db.Options.Where(opt => opt.SpotId == viewModel.SpotId.Value && opt.SurfaceId == viewModel.SurfaceId.Value).FirstOrDefault();
            if (answer == null)
            {
                answer = db.Options.Where(opt => opt.SpotId == viewModel.SpotId.Value).FirstOrDefault();
            }

            ViewBag.ans = answer.Description;
            return PartialView("ShowResult");
        }
    }
}