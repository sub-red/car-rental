using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Application.Interfaces;
using CarRental.Infrastructure.Services;
using CarRental.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarRental.MVC.Controllers
{
    public class RentalsController : Controller
    {
        private readonly IRentalService rentalService;
        private readonly IRentalLoanService rentalLoanService;

        public RentalsController(IRentalService rentalService, IRentalLoanService rentalLoanService)
        {
            this.rentalService = rentalService;
            this.rentalLoanService = rentalLoanService;
        }
        // GET: Rentals
        public ActionResult Index()
        {
            var vm = new RentalIndexVm();
            vm.Rentals = rentalService.GetAllAvailableCars();
            return View(vm);
        }

        // GET: Rentals/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rentals/Create
        public ActionResult Create()
        {
            var vm = new RentalCreateVm();
            vm.RentalAvailableList = new SelectList(rentalService.GetAllAvailableCars(), "Id", "Manufacturer");
            return View(vm);
        }

        // POST: Rentals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Rentals/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rentals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Rentals/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rentals/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}