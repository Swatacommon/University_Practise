using MVC_architecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_architecture.Controllers
{
    public class HomeController : Controller
    {
        PhoneRepository phoneRepository = new PhoneRepository();

        public ActionResult Index()
        {
            return View(phoneRepository.GetAllPhones());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Phone phone)
        {
            phoneRepository.Add(phone);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var phone = phoneRepository.Get(id);
            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }


        [HttpPost]
        public ActionResult Update(Phone phone)
        {
            phoneRepository.Update(phone);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var phone = phoneRepository.Get(id);
            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteSave(int id)
        {
            phoneRepository.Remove(phoneRepository.Get(id));
            return RedirectToAction("Index");
        }
    }
}
