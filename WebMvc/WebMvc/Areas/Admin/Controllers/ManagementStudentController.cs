using Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Areas.Admin.Controllers
{
    public class ManagementStudentController : Controller
    {
        //
        // GET: /Admin/ManagementStudent/

        public ActionResult Index()
        {
            var list = new StudentModels();
            var model = list.ListAll();
            return View(model);
            //return View();
        }

        //
        // GET: /Admin/ManagementStudent/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/ManagementStudent/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/ManagementStudent/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DB_Students students)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var model = new StudentModels();
                    int res = model.Create(students.Student_Code, students.Student_Name,
                                            students.Student_Class, students.Student_IdentityCard,
                                            students.Student_Point, students.Student_Comment,
                                            students.Student_Status, students.Student_Address,
                                            students.Student_Born, students.Student_BirthDay,
                                            students.Student_Parents, students.Student_Image);
                    if (res > 0)
                        return RedirectToAction("Index");
                    else
                    {
                        ModelState.AddModelError("", "Add don't success");
                    }
                }

                return View(students);
                
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManagementStudent/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/ManagementStudent/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManagementStudent/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/ManagementStudent/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
