using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Utils.ViewModels.UserVM;
using uApply.Data.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using uApply.Utils.ViewModels.EducationVM;
using uApply.Data.Models.Education;

namespace uApply.Web.Areas.User.Controllers
{
    [Area("User")]
    public class LearnerController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LearnerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Upsert(int? id, int? parentId)
        {
            var learnerVM = new LearnerViewModel()
            {
                Learner = new Learner(),

                SchoolLevel = unitOfWork.SchoolLevel.GetAll().Select(s => new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Id.ToString()
                }),


                Grades = unitOfWork.Grade.GetAll().Select(g => new SelectListItem
                {
                    Value = g.Name,
                    Text = g.Id.ToString()
                }),

                Genders = unitOfWork.Gender.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                
                Titles = unitOfWork.Title.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),

                Races = unitOfWork.Race.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),

                Nationalities = unitOfWork.Nationality.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Languages = unitOfWork.Language.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Towns = unitOfWork.Town.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                })


        };

            if (parentId != null) learnerVM.Learner.ParentId = parentId.GetValueOrDefault();

            if (id == null) return View(learnerVM);

            learnerVM.Learner = unitOfWork.Learner.Get(id.GetValueOrDefault());

            if(learnerVM.Learner == null) return NotFound();    

            return View(learnerVM);
        }
                

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(LearnerViewModel learnerViewModel)
        {
            if (ModelState.IsValid)
            {

                if (learnerViewModel.Learner.Id == 0)
                {

                    learnerViewModel.Learner.GradeId = 1;
                    unitOfWork.Learner.Add(learnerViewModel.Learner);

                }
                else
                {
                    
                    unitOfWork.Learner.Update(learnerViewModel.Learner);
                }
                unitOfWork.Save();
                return RedirectToAction("Profile", "Parent", new {id = learnerViewModel.Learner.ParentId});
            }
            else
            {
                learnerViewModel.Genders = unitOfWork.Gender.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                learnerViewModel.Titles = unitOfWork.Title.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                learnerViewModel.Races = unitOfWork.Race.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                learnerViewModel.Nationalities = unitOfWork.Nationality.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                learnerViewModel.Languages = unitOfWork.Language.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                learnerViewModel.Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                learnerViewModel.Towns = unitOfWork.Town.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });


                if (learnerViewModel.Learner.Id != 0)
                {
                    learnerViewModel.Learner = unitOfWork.Learner.Get(learnerViewModel.Learner.Id);
                }
            }
            return View(learnerViewModel);
        }

        public IActionResult Apply(int id)
        {
            var schoolApplicationVM = new SchoolApplicationViewModel();

            var schoolApplicationFromDb = unitOfWork.SchoolApplication.Get(id);

            schoolApplicationVM.SchoolApplication = schoolApplicationFromDb;

            //var learners = unitOfWork.Learner.GetAll(l => l.ParentId == parentFromDb.Id);

            //if (!learners.Any()) return View(parentVM);

            //parentVM.Learners = learners;

            return View(schoolApplicationVM);
        }
    }
}
