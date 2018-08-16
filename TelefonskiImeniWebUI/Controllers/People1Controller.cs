using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using TelefonskiImenik.Model;
using BLL.Interfaces;
using BLL;
using BLL.viewModels;
using DAL.Repositories;

namespace TelefonskiImeniWebUI.Controllers
{
    public class People1Controller : Controller
    {
      
        private IService<Person> service;

        public People1Controller(IService<Person> service)
        {
            this.service = service;
        }

        //
        // GET: /Store/
        public ActionResult Index(string searchString)
        {
            
            var people = this.service.GetAll();
            if (!String.IsNullOrEmpty(searchString))
            {
                people = people.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper())
                                       || s.FirstName.ToUpper().Contains(searchString.ToUpper()));
            }
            
            return View(people);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            var people = this.service.GetById(id);
            return View(people);
        }

     
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Create(Person person)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    this.service.Add(person);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Verify your data entries !");
            }
            return View(person);
        }

       
        public ActionResult Edit(int? id)
        {
            Person person = this.service.GetById(id);
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstName,RegistrationDate")]  Person person)
        {
            
            try
            {
               
                if (ModelState.IsValid)
                {
                   
                    this.service.Update(person);

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
            return View();
        }
        
    }
}
