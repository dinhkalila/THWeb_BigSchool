using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THWeb_BigSchool.Models;
using THWeb_BigSchool.ViewModels;

namespace THWeb_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
        [ValidateAntiForgeryToken]
      
        public ActionResult Create(CourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.category = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LecturerID = User.Identity.GetUserId(),
                Datetime = viewModel.GetDateTime(),
                CategoryID = viewModel.Category,
                Place = viewModel.Place,
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();

            return RedirectToAction("Index","Home");
        }
    }
}