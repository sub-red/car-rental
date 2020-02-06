using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Application.Interfaces;
using CarRental.Domain;
using CarRental.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.MVC.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService carService;
        private readonly ICarManufacturerService carManufacturerService;

        public CarsController(ICarService carService, ICarManufacturerService carManufacturerService)
        {
            this.carService = carService;
            this.carManufacturerService = carManufacturerService;
        }

        // GET: Car
        public ActionResult Index()
        {
            var vm = new CarIndexVm();
            vm.Cars = carService.GetAllCars();
            return View(vm);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            var vm = new CarCreateVm();
            return View(vm);
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarCreateVm vm)
        {
            // TODO: Add insert logic here
            if (true)
            {
                //Create new car
                var newCar = new CarDetails();
                newCar.ManufacturerId = vm.ManufacturerId;
                //newCar.CarManufacturer = vm.CarManufacturer;
                newCar.Model = vm.Model;
                newCar.Price = vm.Price;
                newCar.Color = vm.Color;
                newCar.HorsePower = vm.HorsePower;
                newCar.LicensePlate = vm.LicensePlate;

                carService.AddCar(newCar);
                
            }
            return RedirectToAction(nameof(Index));
            /*
            else
            {
                return RedirectToAction("Error", "Home", "");
            }
            */

        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Car/Edit/5
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

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Car/Delete/5
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