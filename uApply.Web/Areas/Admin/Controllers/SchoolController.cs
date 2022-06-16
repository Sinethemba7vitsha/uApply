using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;
using uApply.Utils.ViewModels.EducationVM;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SchoolController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SchoolController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var schools = unitOfWork.School.GetAll(includeProperties: "Town,SchoolLevel");
            return View(schools);
        }

        public IActionResult Upsert(int? id)
        {


            SchoolViewModel schoolViewModel = new SchoolViewModel()
            {
                School = new School(),
                Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Towns = unitOfWork.Town.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                SchoolLevels = unitOfWork.SchoolLevel.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                })

            };


            if (id == null) return View(schoolViewModel);

            schoolViewModel.School = unitOfWork.School.GetAll(s => s.Id == id.GetValueOrDefault(), includeProperties: "Town").FirstOrDefault();
            schoolViewModel.District = unitOfWork.District.Get(schoolViewModel.School.Town.DistrictId);

            if (schoolViewModel.School == null) return NotFound();

            return View(schoolViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(SchoolViewModel schoolViewModel)
        {
            if (ModelState.IsValid)
            {

                if (schoolViewModel.School.Id != 0)
                {
                    School objFromDb = unitOfWork.School.Get(schoolViewModel.School.Id);
                }


                if (schoolViewModel.School.Id == 0)
                {
                    unitOfWork.School.Add(schoolViewModel.School);

                }
                else
                {
                    unitOfWork.School.Update(schoolViewModel.School);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Profile), new { id = schoolViewModel.School.Id });
            }
            else
            {
                schoolViewModel.Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                schoolViewModel.Towns = unitOfWork.Town.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()

                });
                schoolViewModel.SchoolLevels = unitOfWork.SchoolLevel.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()

                });

                if (schoolViewModel.School.Id != 0)
                {
                    schoolViewModel.School = unitOfWork.School.Get(schoolViewModel.School.Id);
                }
            }
            return View(schoolViewModel);
        }

        public IActionResult Profile(int id)
        {
            var schoolVM = new SchoolViewModel();

            var schoolFromDb = unitOfWork.School.GetAll(s => s.Id == id, includeProperties: "Town,SchoolLevel").FirstOrDefault();

            schoolVM.School = schoolFromDb;

            ViewBag.JavaScriptFunction = string.Format($"setLoggedUser('{schoolFromDb.Id}', 'SCHOOL', '{schoolFromDb.Name.Split(' ')[0]}', '/Admin/School/Profile/{schoolFromDb.Id}');");

            var applications = unitOfWork.SchoolApplication.GetAll(a => a.SchoolId == id, includeProperties: "Learner,Grade,Status");

            if (!applications.Any()) return View(schoolVM);

            schoolVM.Applications = applications;

            return View(schoolVM);
        }

        public IActionResult LearnerApplicationView(int applicationId)
        {

            var application = unitOfWork.SchoolApplication.GetAll(a => a.Id == applicationId, includeProperties: "Learner,Grade,Status").FirstOrDefault();

            if (application == null) return NotFound();

            return View(application);
        }


        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var schools = unitOfWork.School.GetAll();

            if (schools == null) return Json(new { success = false, message = "Erro while fetching data...." });

            return Json(new { data = schools });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var gradeToDelete = unitOfWork.Grade.Get(id);

            if (gradeToDelete == null) return Json(new { success = false, message = "Failed to delete" });

            unitOfWork.Grade.Remove(id);
            unitOfWork.Save();

            return Json(new { success = true, message = "Succesfuly deleted!", id = id });

        }

        [HttpPut]
        public IActionResult UpdateStatus(int applicationId, int statusId)
        {
            var applicationFromDb = unitOfWork.SchoolApplication.Get(applicationId);

            if (applicationFromDb == null) return Json(new { success = false, message = "Failed to update" });

            applicationFromDb.StatusId = statusId;

            unitOfWork.SchoolApplication.Update(applicationFromDb);
            unitOfWork.Save();

            return Json(new { success = true, message = "Succesfuly updated!"});

        }


        [HttpGet]
        public IActionResult GetSchools()
        {
            var schools = unitOfWork.School.GetAll();
            return Json(new { data = schools, success = true });
        }

        //[HttpGet("{id:int}")]
        //public IActionResult GetParent(int id)
        //{
        //    var parent = unitOfWork.Parent.Get(id);

        //    return Json(new { data = parent});
        //}

        //[HttpGet("{parentId:int}")]
        //public IActionResult Learners(int parentId)
        //{
        //    var learners = unitOfWork.Learner.GetAll(l => l.ParentId == parentId);

        //    if (learners == null) return Json(new { success = false, message = "Erro while fetching data...." });

        //    return Json(new { data = learners });
        //}


        #endregion

    }
}
