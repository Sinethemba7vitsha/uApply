using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LanguageController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LanguageController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var languages = unitOfWork.Language.GetAll();

            return View(languages);
        }

        public IActionResult Upsert(int? id)
        {
            Language language = new Language();

            if (id == null) return View(language);

            language = unitOfWork.Language.Get(id.GetValueOrDefault());

            if (language == null) return NotFound();

            return View(language);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Language language)
        {
            //if (ModelState.IsValid)
            //{

            //    if (language.Id != 0)
            //    {
            //        var objFromDb = unitOfWork.Parent.Get(language.Id);
            //    }


            //    if (language.Id == 0)
            //    {
            //        language.UserId = 1; //free state
            //        unitOfWork.Language.Add(language);
            //    }
            //    else
            //    {
            //        language.UserId = 1; //free state
            //        unitOfWork.Language.Update(language);
            //    }
            //    unitOfWork.Save();
            //    return RedirectToAction(nameof(Index));
            //}

            return View(language);
        }


    }
}
