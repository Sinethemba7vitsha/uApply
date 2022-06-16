using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Location;
using uApply.Utils.ViewModels;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TownController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TownController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var towns = unitOfWork.Town.GetAll(includeProperties: "District");
            
            return View(towns);
        }

        public IActionResult Upsert(int? id)
        {

            TownViewModel townViewModel = new TownViewModel()
            {
                Town = new Town(),
                Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                })
            };

            if (id == null) return View(townViewModel);

            townViewModel.Town = unitOfWork.Town.Get(id.GetValueOrDefault());
            townViewModel.District = unitOfWork.District.GetAll( d => d.Id == id.GetValueOrDefault()).FirstOrDefault();

            
            return View(townViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(TownViewModel townViewModel)
        {
            if (ModelState.IsValid)
            {

               
                if (townViewModel.Town.Id == 0)
                {
                    townViewModel.Town.DistrictId = townViewModel.District.Id; 
                    unitOfWork.Town.Add(townViewModel.Town);
                }
                else
                {
                    townViewModel.Town.DistrictId = townViewModel.District.Id;
                    unitOfWork.Town.Update(townViewModel.Town);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {

            }

            return View(townViewModel);
        }

        [HttpGet]
        public IActionResult GetTowns()
        {
            var towns = unitOfWork.Town.GetAll();
            return Json(new {data = towns, success = true});
        }
    }
}
