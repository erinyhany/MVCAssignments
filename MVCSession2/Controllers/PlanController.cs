using Microsoft.AspNetCore.Mvc;
using MVCSession2.Contexts;
using MVCSession2.Entities;
using Microsoft.EntityFrameworkCore;



namespace MVCSession2.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContext dbContext = new GymDbContext();

        //me4 lazem yrg3 view bnfs esm el action  
        public IActionResult IndexTest()
        {
            return View(); //return view with the same name of the action : views/Plan/IndexTest.cshtml (first overload)
            //return View("Test"); //return view with the name of the view test : views/Plan/Test.cshtml (third overload)
            //return View(new Member() {Id = 1}); //return view with the same name of the action and pass model to the view : views/Plan/IndexTest.cshtml (second overload)
           // return View("Test", new Member() { Id = 1 }); //return view with the name of the view test and pass model to the view : views/Plan/Test.cshtml (fourth overload)
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var plans = await dbContext.Plans.ToListAsync();
            return View(plans);
        }
    }
}
