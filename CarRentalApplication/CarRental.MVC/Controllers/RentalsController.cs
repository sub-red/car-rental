using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Application.Interfaces;
using CarRental.Domain;
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
        private readonly ICarService carService;
        private readonly IMemberService memberService;

        public RentalsController(IRentalService rentalService, ICarService carService, IMemberService memberService)
        {
            this.rentalService = rentalService;
            this.carService = carService;
            this.memberService = memberService;
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
            vm.CarList = new SelectList(carService.GetAllCars(), "Id", "LicensePlate", "Id", "Model");
            vm.MembersList = new SelectList(memberService.GetAllMembers(), "Id", "DriversLicense", "Id", "FullName");
            return View(vm);
        }

        // POST: Rentals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RentalCreateVm vm)
        {
            vm.CarList = new SelectList(carService.GetAllCars(), "Id", "LicensePlate", "Id", "Model");
            vm.MembersList = new SelectList(memberService.GetAllMembers(), "Id", "DriversLicense", "Id", "FullName");
            // TODO: Add insert logic here
            if (!ModelState.IsValid)
                return View(vm);
            {
                var newRental = new Rentals();
                newRental.Rented = vm.Rented;
                //newRental.Returned = vm.Returned;
                newRental.ExpectedReturn = vm.ExpectedReturn;
                newRental.CarReferenceId = vm.CarReferenceId;
                newRental.MemberReferenceId = vm.MemberCardId;

                rentalService.AddRental(newRental);
                return RedirectToAction(nameof(Index));
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