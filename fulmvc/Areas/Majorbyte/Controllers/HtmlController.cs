using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fulmvc.Areas.Majorbyte.Controllers
{
    public class HtmlController : Controller
    {
        //
        // GET: /Majorbyte/Html/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Majorbyte/Html/Details/5

        public ActionResult FlexBox()
        {
            return View();
        }

        public PartialViewResult flexorder()
        {
            return PartialView("_FlexOrder");
        }

        //
        // GET: /Majorbyte/Html/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Majorbyte/Html/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Majorbyte/Html/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Majorbyte/Html/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Majorbyte/Html/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Majorbyte/Html/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
