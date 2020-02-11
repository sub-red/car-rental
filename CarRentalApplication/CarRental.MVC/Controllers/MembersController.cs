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
    public class MembersController : Controller
    {
        private readonly IMemberService memberService;
        private readonly IMemberCardService memberCardService;

        public MembersController(IMemberService memberService, IMemberCardService memberCardService)
        {
            this.memberService = memberService;
            this.memberCardService = memberCardService;
        }

        // GET: Members
        public ActionResult Index()
        {
            var vm = new MemberIndexVm();
            vm.Members = memberService.GetAllMembers();
            return View(vm);
        }

        // GET: Members/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            var vm = new MemberCreateVm();
            //vm.MemberStatusList = new SelectList(memberCardService.GetAllMemberCards(), "Id", "Member-Status");
            return View(vm);

        }

        // POST: Members/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberCreateVm vm)
        {
            //vm.MemberStatusList = new SelectList(memberCardService.GetAllMemberCards(), "Id", "Member-Status");
            if (!ModelState.IsValid)
                return View(vm);
            {
                //Create new car
                var newMember = new MemberDetails();
                newMember.FirstName = vm.FirstName;
                newMember.LastName = vm.LastName;
                newMember.Adress = vm.Adress;
                newMember.Age = vm.Age;
                newMember.DriversLicense = vm.DriversLicense;
                newMember.MemberCardId = vm.MemberCardId;
                

                memberService.AddMember(newMember);
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Members/Edit/5
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

        // GET: Members/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Members/Delete/5
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