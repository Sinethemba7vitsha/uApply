using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SchoolLevelController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SchoolLevelController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var schoolLevels = unitOfWork.SchoolLevel.GetAll(includeProperties: "School");

            return View(schoolLevels);
        }

        public IActionResult Upsert(int? id)
        {
            SchoolLevel schoolLevel = new SchoolLevel();

            if (id == null) return View(schoolLevel);

            schoolLevel = unitOfWork.SchoolLevel.Get(id.GetValueOrDefault());

            if (schoolLevel == null) return NotFound();

            return View(schoolLevel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(SchoolLevel schoolLevel)
        {
            if (ModelState.IsValid)
            {

                if (schoolLevel.Id != 0)
                {
                    var objFromDb = unitOfWork.Parent.Get(schoolLevel.Id);
                }


                if (schoolLevel.Id == 0)
                {
                    //schoolLevel.SchoolId = 1;
                    unitOfWork.SchoolLevel.Add(schoolLevel);
                }
                else
                {
                    //schoolLevel.SchoolId = 1;
                    unitOfWork.SchoolLevel.Update(schoolLevel);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(schoolLevel);
        }

    }
}
