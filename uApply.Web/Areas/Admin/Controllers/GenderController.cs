using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenderController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public GenderController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var gender = unitOfWork.Gender.GetAll(includeProperties: "User");

            return View(gender);
        }

        public IActionResult Upsert(int? id)
        {
            Gender gender = new Gender();

            if (id == null) return View(gender);

            gender = unitOfWork.Gender.Get(id.GetValueOrDefault());

            if (gender == null) return NotFound();

            return View(gender);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Gender gender)
        {
            //if (ModelState.IsValid)
            //{

            //    if (gender.Id != 0)
            //    {
            //        var objFromDb = unitOfWork.Parent.Get(gender.Id);
            //    }


            //    if (gender.Id == 0)
            //    {
            //        gender.UserId = 1; 
            //        unitOfWork.Gender.Add(gender);
            //    }
            //    else
            //    {
            //        gender.UserId = 1; 
            //        unitOfWork.Gender.Update(gender);
            //    }
            //    unitOfWork.Save();
            //    return RedirectToAction(nameof(Index));
            //}

            return View(gender);
        }
    }
}
