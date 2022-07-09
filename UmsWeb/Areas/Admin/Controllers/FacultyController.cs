using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UmsWeb.DataAccess.Repository.IRepository;
using UmsWeb.Models;

namespace UmsWeb.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class FacultyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public FacultyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            var course = _unitOfWork.Faculty.GetAll();
            return View(course);
        }
        [Area("Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [Area("Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Faculty obj)
        {
            _unitOfWork.Faculty.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "Added Successfully";
            return RedirectToAction("Index");
        }
        [Area("Admin")]
        //Get
        public IActionResult Edit(int? id)
        {
            var course = _unitOfWork.Faculty.GetFirstOrDefault(u=>u.Id==id);
            return View(course);
        }
        [Area("Admin")]
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Faculty obj)
        {
            _unitOfWork.Faculty.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "Updated Successfully";
            return RedirectToAction("Index");
        }
        [Area("Admin")]
        public IActionResult Delete(int? id)
        {
            var obj = _unitOfWork.Faculty.GetFirstOrDefault(u => u.Id == id);
            _unitOfWork.Faculty.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
