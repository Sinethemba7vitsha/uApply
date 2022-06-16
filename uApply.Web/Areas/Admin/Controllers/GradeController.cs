using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Education;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GradeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public GradeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var grades = unitOfWork.Grade.GetAll(includeProperties: "SchoolLevel");

            return View(grades);
        }

        public IActionResult Upsert(int? id)
        {
            Grade grade = new Grade();

            if (id == null) return View(grade);

            grade = unitOfWork.Grade.Get(id.GetValueOrDefault());

            if (grade == null) return NotFound();

            return View(grade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Grade grade)
        {
            if (ModelState.IsValid)
            {

                if (grade.Id != 0)
                {
                    var objFromDb = unitOfWork.Parent.Get(grade.Id);
                }


                if (grade.Id == 0)
                {
                    grade.SchoolLevelId = 1;
                    unitOfWork.Grade.Add(grade);
                }
                else
                {
                    grade.SchoolLevelId = 1;
                    unitOfWork.Grade.Update(grade);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(grade);
        }

        [HttpGet]
        public IActionResult GetGrades()
        {
            var grades = unitOfWork.Grade.GetAll();
            return Json(new { data = grades, success = true });
        }
    }
}
