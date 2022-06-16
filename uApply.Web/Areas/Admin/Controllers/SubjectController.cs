using Microsoft.AspNetCore.Mvc;

namespace uApply.Web.Areas.Admin.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
