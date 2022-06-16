using Microsoft.AspNetCore.Mvc;
using System.Linq;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;
using uApply.Utils.ViewModels.UserVM;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace uApply.Web.Areas.User.Controllers
{
    [Area("User")]
    public class ParentController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ParentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var parents = unitOfWork.Parent.GetAll(includeProperties: "Nationality,Town,Title,Gender,Race,Language");
            return View(parents);
        }

        public IActionResult Upsert(int? id)
        {


            ParentViewModel parentViewModel = new ParentViewModel()
            {
                Parent = new Parent(),
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
                })

            };


            if (id == null) return View(parentViewModel);

            parentViewModel.Parent = unitOfWork.Parent.Get(id.GetValueOrDefault());

            if (parentViewModel.Parent == null) return NotFound();

            return View(parentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ParentViewModel parentViewModel)
        {
            if (ModelState.IsValid)
            {

                if (parentViewModel.Parent.Id != 0)
                {
                    Parent objFromDb = unitOfWork.Parent.Get(parentViewModel.Parent.Id);
                }


                if (parentViewModel.Parent.Id == 0)
                {
                    parentViewModel.Parent.TownId = 1;
                    unitOfWork.Parent.Add(parentViewModel.Parent);

                }
                else
                {
                    parentViewModel.Parent.TownId = 1;
                    unitOfWork.Parent.Update(parentViewModel.Parent);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Profile), new {id = parentViewModel.Parent.Id});
            }
            else
            {
                parentViewModel.Genders = unitOfWork.Gender.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Titles = unitOfWork.Title.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Races = unitOfWork.Race.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Nationalities = unitOfWork.Nationality.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Languages = unitOfWork.Language.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });


                if (parentViewModel.Parent.Id != 0)
                {
                    parentViewModel.Parent = unitOfWork.Parent.Get(parentViewModel.Parent.Id);
                }
            }
            return View(parentViewModel);
        }

        public IActionResult Profile(int id)
        {
            var parentVM = new ParentViewModel();
            
            var parentFromDb = unitOfWork.Parent.Get(id);

            parentVM.Parent = parentFromDb;

            ViewBag.JavaScriptFunction = string.Format($"setLoggedUser('{parentFromDb.Id}', 'PARENT', '{parentFromDb.FullNames.Split(' ')[0]}', '/User/Parent/Profile/{parentFromDb.Id}');");

            var learners = unitOfWork.Learner.GetAll(l => l.ParentId == parentFromDb.Id);

            if (!learners.Any()) return View(parentVM);

            parentVM.Learners = learners;
            parentVM.SchoolApplications = unitOfWork.SchoolApplication.GetAll();


            return View(parentVM);
        }


        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var parents = unitOfWork.Parent.GetAll();

            if (parents == null) return Json(new { success = false, message = "Erro while fetching data...." });

            return Json(new { data = parents });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var learnerToDelete = unitOfWork.Learner.Get(id);

            if(learnerToDelete == null) return Json(new {success = false, message = "Failed to delete"});

            unitOfWork.Learner.Remove(id);
            unitOfWork.Save();

            return Json(new {success = true, message = "Succesfuly deleted!", id = id});

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
