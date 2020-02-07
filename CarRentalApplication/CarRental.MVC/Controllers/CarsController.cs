using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Application.Interfaces;
using CarRental.Domain;
using CarRental.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            vm.CarManufacturerList = new SelectList(carManufacturerService.GetAllCarManufacturers(), "Id", "Manufacturer");
            return View(vm);
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarCreateVm vm)
        {
            vm.CarManufacturerList = new SelectList(carManufacturerService.GetAllCarManufacturers(), "Id", "Manufacturer"); //Bad practice but necessary for the moment
            // TODO: Add insert logic here
            if (!ModelState.IsValid)
                return View(vm);
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
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            var vm = new CarEditVm();
            vm.Id = id;
            vm.CarManufacturerList = new SelectList(carManufacturerService.GetAllCarManufacturers(), "Id", "Manufacturer");
            return View(vm);
        }

        // POST: Car/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CarEditVm vm, int id)
        {
            vm.CarManufacturerList = new SelectList(carManufacturerService.GetAllCarManufacturers(), "Id", "Manufacturer");
            if (!ModelState.IsValid)
                return View(vm);
            {
                // TODO: Add update logic here
                var updatedCar = new CarDetails();
                updatedCar.Id = vm.Id; // Might not need
                updatedCar.ManufacturerId = vm.ManufacturerId;
                updatedCar.LicensePlate = vm.LicensePlate;
                updatedCar.Model = vm.Model;
                updatedCar.Price = vm.Price;
                updatedCar.HorsePower = vm.HorsePower;
                updatedCar.Color = vm.Color;

                carService.UpdateCarDetails(updatedCar);


                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            var vm = new CarDetails();
            vm.Id = id;
            return View();
        }

        // POST: Car/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CarDeleteVm vm, int id)
        {
            if (!ModelState.IsValid)
                return View(vm);
            {
                var carToDelete = new CarDetails();
                carToDelete.Id = vm.Id;

                carService.DeleteCar(carToDelete);

                return RedirectToAction(nameof(Index));
            }
        }
    }
}