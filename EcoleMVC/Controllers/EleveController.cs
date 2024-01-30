using EcoleMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonEcole.BL;
using MonEcole.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoleMVC.Controllers
{
    public class EleveController : Controller
    {
        private IEleveService eleveService;

        public EleveController(IEleveService elService)
        {
            eleveService = elService;
        }

        // GET: EleveController
        public ActionResult Index()
        {
            List<EleveViewModel> eleves = eleveService.GetAll().Select(e => new EleveViewModel(e)).ToList();
            return View(eleves);
        }

        // GET: EleveController/Details/5
        public ActionResult Details(int id)
        {
            return View(new EleveViewModel(eleveService.GetById(id)));
        }


        // GET: EleveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EleveController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EleveViewModel vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    eleveService.Create(vm.GetModel);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(vm);
            }
        }

        // GET: EleveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EleveController/Edit/5
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

        // GET: EleveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EleveController/Delete/5
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
