using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepartmentsService = Demo.Service.Logic.DepartmentsService;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo.Web.Controllers
{
    [Authorize]
    public class DepartmentsController : Controller
    {
        private readonly DepartmentsService departmentsService;

        public DepartmentsController( DepartmentsService departmentsService)
        {
            this.departmentsService = departmentsService;
        }

        public IActionResult Index()
        {
            var res = departmentsService.GetAll();
            return View(res);
        }

        public IActionResult New()
        {
            return View(new DAL.Entities.Departments()
            {
                ID = Guid.NewGuid(),
                IsDeleted = false,
                CreateDateTime = DateTimeOffset.Now
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(DAL.Entities.Departments Departments)
        {

            if (!ModelState.IsValid)
            {
                return View(Departments);
            }
            Departments.SyncClientID = Guid.NewGuid();
            Departments.SyncTime = DateTimeOffset.Now;
            var Res = departmentsService.Add(Departments);
            if (Res)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                SetDepartmentsList();
                ModelState.AddModelError(string.Empty, "Not Added");
                return View(Departments);
            }
        }

        private void SetDepartmentsList(Guid? DefaultSelected = null)
        {
            var depts = departmentsService.GetAll();
            ViewBag.DepartmentID =  new SelectList(depts, "ID", "Name", DefaultSelected);
        }


        public IActionResult Edit(Guid id)
        {
            return View(departmentsService.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id,DAL.Entities.Departments Departments)
        {

            if (!ModelState.IsValid)
            {
                SetDepartmentsList();
                return View(Departments);
            }

            Departments.ModifiedDate = DateTimeOffset.Now;
            Departments.SyncClientID = Guid.NewGuid();
            Departments.SyncTime = DateTimeOffset.Now;

            var Res = departmentsService.Update(Departments);
            if (Res)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                SetDepartmentsList();
                ModelState.AddModelError(string.Empty, "Not Added");
                return View(Departments);
            }
        }


        public IActionResult Details(Guid id)
        {
            return View(departmentsService.Get(id));
        }


    }
}
