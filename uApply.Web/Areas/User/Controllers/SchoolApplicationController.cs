using Microsoft.AspNetCore.Mvc;
using System.Linq;
using uApply.DAL.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using uApply.Utils.ViewModels.EducationVM;
using uApply.Data.Models.Education;
using System;

namespace uApply.Web.Areas.User.Controllers
{
    [Area("User")]
    public class SchoolApplicationController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SchoolApplicationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var schoolApplications = unitOfWork.SchoolApplication.GetAll(includeProperties: "Grade,Learner,School");
            return View(schoolApplications);
        }

        public IActionResult Upsert(int? id, int learnerId, int parentId)
        {


            SchoolApplicationViewModel schoolApplicationViewModel = new SchoolApplicationViewModel()
            {
                SchoolApplication = new SchoolApplication(),

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
                }),
                Schools = unitOfWork.School.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Grades = unitOfWork.Grade.GetAll().OrderBy(g => Convert.ToInt32(g.Name)).Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                })

            };

            schoolApplicationViewModel.SchoolApplication.LearnerId = learnerId;
            schoolApplicationViewModel.ParentId = parentId;

            if (id == null) return View(schoolApplicationViewModel);

            schoolApplicationViewModel.SchoolApplication = unitOfWork.SchoolApplication.Get(id.GetValueOrDefault());

            if (schoolApplicationViewModel.SchoolApplication == null) return NotFound();

            return View(schoolApplicationViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(SchoolApplicationViewModel schoolApplicationViewModel)
        {
            if (ModelState.IsValid)
            {

                if (schoolApplicationViewModel.SchoolApplication.Id != 0)
                {
                    SchoolApplication objFromDb = unitOfWork.SchoolApplication.Get(schoolApplicationViewModel.SchoolApplication.Id);
                }


                if (schoolApplicationViewModel.SchoolApplication.Id == 0)
                {
                    schoolApplicationViewModel.SchoolApplication.StatusId = 1;
                    unitOfWork.SchoolApplication.Add(schoolApplicationViewModel.SchoolApplication );

                }
                else
                {
                    schoolApplicationViewModel.SchoolApplication.SchoolId = 1;
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Profile), "Parent",  new { id = schoolApplicationViewModel.ParentId });
            }
            else
            {
                schoolApplicationViewModel.Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                schoolApplicationViewModel.Towns = unitOfWork.Town.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                schoolApplicationViewModel.SchoolLevels = unitOfWork.SchoolLevel.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                schoolApplicationViewModel.Schools = unitOfWork.School.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                schoolApplicationViewModel.Grades = unitOfWork.Grade.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });


                if (schoolApplicationViewModel.SchoolApplication.Id != 0)
                {
                    schoolApplicationViewModel.SchoolApplication = unitOfWork.SchoolApplication.Get(schoolApplicationViewModel.SchoolApplication.Id);
                }
            }
            return View(schoolApplicationViewModel);
        }

        public IActionResult Profile(int id)
        {
            var schoolApplicationVM = new SchoolApplicationViewModel();

            var applicationFromDb = unitOfWork.SchoolApplication.Get(id);

            schoolApplicationVM.SchoolApplication = applicationFromDb;

            //var grades = unitOfWork.SchoolApplication.GetAll(l => l.SchoolApplicationId == schoolApplicationFromDb.Id);

            //if (!grades.Any()) return View(schoolApplicationVM);

            //schoolApplicationVM.Grades = grades;

            return View(schoolApplicationVM);
        }


        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var schoolapplications = unitOfWork.SchoolApplication.GetAll();

            if (schoolapplications == null) return Json(new { success = false, message = "Erro while fetching data...." });

            return Json(new { data = schoolapplications });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var schoolapplicationToDelete = unitOfWork.SchoolApplication.Get(id);

            if (schoolapplicationToDelete == null) return Json(new { success = false, message = "Failed to delete" });

            unitOfWork.SchoolApplication.Remove(id);
            unitOfWork.Save();

            return Json(new { success = true, message = "Succesfuly deleted!", id = id });

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
