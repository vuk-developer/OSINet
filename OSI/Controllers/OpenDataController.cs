using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OSI.Models;

namespace OSI.Controllers
{
    public class OpenDataController : Controller
    {
        OSIContext context = new OSIContext();

        // GET: OpenDataController
        [Route("/otvoreni-podaci")]
        public ActionResult OtvoreniPodaci()
        {
            Knjige[] knjige = context.Knjige.ToArray();
            ViewBag.OpenData = knjige;
            return View();
        }
        [Route("/openosi")]
        public ActionResult OpenOSI()
        {
            return View();
        }

        [Route("/otvoreni-podaci/zabranjen-pristup")]
        public ActionResult ZabranjenPristup(string razlog)
        {
            ViewBag.Razlog = razlog;
            return View();
        }



        // GET: OpenDataController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OpenDataController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OpenDataController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OpenDataController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OpenDataController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OpenDataController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
