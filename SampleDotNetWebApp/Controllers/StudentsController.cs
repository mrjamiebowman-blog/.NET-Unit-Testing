using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleDotNetWebApp.Controllers
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