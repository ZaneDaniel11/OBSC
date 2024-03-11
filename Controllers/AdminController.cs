using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OBSC.Entities;

namespace OBSC.Controllers
{

    public class AdminController : Controller
    {
        private readonly ObsDbContext _context;

        public AdminController(ObsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
          
            return View(main);
        }

    }
}