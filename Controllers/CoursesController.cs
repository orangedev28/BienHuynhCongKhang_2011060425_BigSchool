using BienHuynhCongKhang_2011060425_Week3.Models;
using BienHuynhCongKhang_2011060425_Week3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienHuynhCongKhang_2011060425_Week3.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CoursesController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = dbContext.Categories.ToList()
            };

            return View(viewModel);
        }
    }
}