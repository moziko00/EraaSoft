using Hospital_Project.Data;
using Hospital_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hospital_Project.Controllers
{
    public class DoctorsController : Controller
    {
        ApplicationDbContext context=new ApplicationDbContext();

        public IActionResult BookAppointment()
        {
            var doctors = context.Doctors.ToList();
            return View(doctors);
        }

        public IActionResult CompleteAppointment(string name)
        {
            var result = context.Doctors.Where(D=>D.Name == name).ToList();
            ViewBag.Name = name;
            return View(result);
        }

    }
}
