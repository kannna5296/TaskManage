using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskManage.Models;
using Microsoft.EntityFrameworkCore;
using TaskManage.Data;

namespace TaskManage.Controllers
{
    public class HomeController : Controller
    { 
        //TODO ログ埋め込む
        private readonly MyDatabaseContext _context;

        public HomeController(MyDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Todo.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Todo todo) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(todo);
                    _context.SaveChanges();
                }　catch (Exception ex )
                {

                }
                return RedirectToAction(nameof(Index));
            } else
            {
                return View(todo);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
