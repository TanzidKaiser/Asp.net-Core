using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly DatabaseContext db;

        public StudentController(DatabaseContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {

            return View(db.Students.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return View();
        }
    }
}