using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketNew.Models;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace MarketNew.Controllers
{
    public class MarketController : Controller
    {

        PhoneContext phoneContext = new PhoneContext();

        public ActionResult Index()
        {
            IEnumerable<Phone> phones = phoneContext.Phones; //извлекаем  данные из таблицы Phones

            ViewBag.Phones = phones; // записываем phones в динамисеское свойство ViewBag

            return View();
        }

       [ HttpGet ]
       public ActionResult Buy(int id)
       {
            ViewBag.id = id;

            return View();
       }

        [HttpPost]
        public string Buy(Purcashe purcashe)
        {
            purcashe.DateTime = DateTime.Now;

            phoneContext.Purcashes.Add(purcashe);

            phoneContext.SaveChanges();

            return $"Уважаемый, {purcashe.FIO}, с вами скоро свяжутся!";
        }

        [HttpGet]
        public ActionResult AddPhone()
        {
            return View();
        }

        [HttpPost]
         public string AddPhone(Phone phone)
         {
             phoneContext.Phones.Add(phone);
             phoneContext.SaveChanges();
             return $"Телефон успешно добавлен";
         }
    }
}