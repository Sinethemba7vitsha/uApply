using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Location;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DistrictController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DistrictController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var districts = unitOfWork.District.GetAll(includeProperties: "Province");

            ViewBag.JavaScriptFunction = string.Format($"setLoggedUser('{-1}', 'MANAGER', 'admin', '');");


            return View(districts);
        }

        public IActionResult Upsert(int? id)
        {
            District district = new District();

            if (id == null) return View(district);

            district = unitOfWork.District.Get(id.GetValueOrDefault());

            if (district == null) return NotFound();

            return View(district);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(District district)
        {
            if (ModelState.IsValid)
            {

                if (district.Id != 0)
                {
                    var objFromDb = unitOfWork.Parent.Get(district.Id);
                }


                if (district.Id == 0)
                {
                    district.ProvinceId = 1; //free state
                    unitOfWork.District.Add(district);
                }
                else
                {
                    district.ProvinceId = 1; //free state
                    unitOfWork.District.Update(district);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(district);
        }


    }
}
