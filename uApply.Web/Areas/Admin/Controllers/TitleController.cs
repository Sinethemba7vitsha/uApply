using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TitleController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TitleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var titles = unitOfWork.Title.GetAll(includeProperties: "User");

            return View(titles);
        }

        public IActionResult Upsert(int? id)
        {
            Title title = new Title();

            if (id == null) return View(title);

            title = unitOfWork.Title.Get(id.GetValueOrDefault());

            if (title == null) return NotFound();

            return View(title);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Title title)
        {
            //if (ModelState.IsValid)
            //{

            //    if (title.Id != 0)
            //    {
            //        var objFromDb = unitOfWork.Parent.Get(title.Id);
            //    }


            //    if (title.Id == 0)
            //    {
            //        title.UserId = 1; //free state
            //        unitOfWork.Title.Add(title);
            //    }
            //    else
            //    {
            //        title.UserId = 1; //free state
            //        unitOfWork.Title.Update(title);
            //    }
            //    unitOfWork.Save();
            //    return RedirectToAction(nameof(Index));
            //}

            return View(title);
        }


    }
}
