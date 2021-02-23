using EFStudents.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudents.Controllers
{
    public class ClassController : Controller
    {
        private readonly ClassContext _classDb;

        public ClassController(ClassContext classContext)
        {
            _classDb = classContext;
        }
        public IActionResult Index()
        {
            return View(_classDb.Students.ToList());
        }
    }
}
