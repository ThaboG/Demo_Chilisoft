using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesService = Demo.Service.Logic.EmployeesService;
using DepartmentsService = Demo.Service.Logic.DepartmentsService;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo.Web.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly EmployeesService employeesService;
        private readonly DepartmentsService departmentsService;

        public EmployeesController(EmployeesService employeesService, DepartmentsService departmentsService)
        {
            this.employeesService = employeesService;
            this.departmentsService = departmentsService;
        }

        public IActionResult Index()
        {
            var res = employeesService.GetAll();
            return View(res);
        }

        public IActionResult New()
        {
            SetDepartmentsList();
            return View(new DAL.Entities.Employees()
            {
                ID = Guid.NewGuid(),
                IsDeleted = false,
                CreateDateTime = DateTimeOffset.Now
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(DAL.Entities.Employees employees)
        {

            if (!ModelState.IsValid)
            {
                SetDepartmentsList();
                return View(employees);
            }
            employees.SyncClientID = Guid.NewGuid();
            employees.SyncTime = DateTimeOffset.Now;
            var Res = employeesService.Add(employees);
            if (Res)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                SetDepartmentsList();
                ModelState.AddModelError(string.Empty, "Not Added");
                return View(employees);
            }
        }

        private void SetDepartmentsList(Guid? DefaultSelected = null)
        {
            var depts = departmentsService.GetAll();
            ViewBag.DepartmentID =  new SelectList(depts, "ID", "Name", DefaultSelected);
        }


        public IActionResult Edit(Guid id)
        {
            SetDepartmentsList();
            return View(employeesService.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id,DAL.Entities.Employees employees)
        {

            if (!ModelState.IsValid)
            {
                SetDepartmentsList();
                return View(employees);
            }

            employees.ModifiedDate = DateTimeOffset.Now;
            employees.SyncClientID = Guid.NewGuid();
            employees.SyncTime = DateTimeOffset.Now;

            var Res = employeesService.Update(employees);
            if (Res)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                SetDepartmentsList();
                ModelState.AddModelError(string.Empty, "Not Added");
                return View(employees);
            }
        }


        public IActionResult Details(Guid id)
        {
            return View(employeesService.Get(id));
        }


    }
}
