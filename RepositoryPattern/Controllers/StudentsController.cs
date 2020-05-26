using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Services;

namespace RepositoryPattern.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IAppService _AppService;

        public StudentsController(IAppService appService)
        {
            _AppService = appService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}