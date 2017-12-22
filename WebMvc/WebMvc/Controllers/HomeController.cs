using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Common;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        //Data temp
        IList<Student> studentList = new List<Student>()
        {
                new Student(){StudentID = 1, StudentName = "John", Age = 18},
                new Student(){StudentID = 2, StudentName = "Dohn", Age = 19},
                new Student(){StudentID = 3, StudentName = "Jonish", Age = 20}
        };

        [TrackExecutionTime]
        public ActionResult Index()
        {
            //Return view Index
            return View(studentList);
        }

        public ActionResult Edit(int StudentID)
        {
            var std = studentList.Where(s => s.StudentID == StudentID).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(std);
        }
    }
}
