using Microsoft.AspNetCore.Mvc;
using MVCCoreExample.Models;

namespace MVCCoreExample.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()

        {
            List<Doctor> dlist = new List<Doctor>();
            Doctor d1 = new Doctor();
            {
                

  

            
              
            

            }
            return View(dlist);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit() 
        {
            return View();
        }
    }
}
