using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Herhaling1.Entities;
using Herhaling1.ViewModels;
using Herhaling1.Repositories;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Herhaling1.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {

        private SchoolRepository repo;

        public StudentController(SchoolRepository schoolrepo)
        {
            repo = schoolrepo;
        }

        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult test()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult list()
        {
            return View(repo.getAllStudenten());
        }

        [Route("[action]/{studnr}")]
        public IActionResult askNumber(int? studnr)
        {
            if(studnr >0 && studnr != null)
            {
              return View(repo.getStudentById(studnr));
            }
            return View("error");
            
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult add()
        {
            return View();
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult add(StudentBasic student)
        {
            if (ModelState.IsValid)
            {
               repo.addStudent(student);        
               return RedirectToAction("list");
            }
            return View();
            
        }

        [Route("[action]/{id}")]
        public IActionResult delete(int id)
        {
            repo.delete(id);
            return RedirectToAction("list");
        }
    }
}
