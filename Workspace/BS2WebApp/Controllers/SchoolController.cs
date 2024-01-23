using BS2WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BS2WebApp.Controllers
{
    public class SchoolController : Controller
    {

        public IActionResult GetSchool()
        {
            SchoolModel bsLinz2 = new SchoolModel()
            {
                Id = 401075,
                Name = "BS Linz 2"
            };

            SchoolModel bsLinz4 = new SchoolModel()
            {
                Id = 401076,
                Name = "Bs Linz 4"
            };

            List<SchoolModel> schoolList = new List<SchoolModel> { bsLinz2, bsLinz4 };

            return View(schoolList);

        }

        public IActionResult EditSchool(int Id)
        {
            SchoolModel bsLinz2 = new SchoolModel()
            {
                Id = 401075,
                Name = "BS Linz 2"
            };

            SchoolModel bsLinz4 = new SchoolModel()
            {
                Id = 401076,
                Name = "Bs Linz 4"
            };

            List<SchoolModel> schoolList = new List<SchoolModel> { bsLinz2, bsLinz4 };

            return View(schoolList.Where(x => x.Id == Id).FirstOrDefault());

        }

        [HttpPost]
        public IActionResult EditSchool(SchoolModel model)
        {
            return View(model);
        }
    }
}
