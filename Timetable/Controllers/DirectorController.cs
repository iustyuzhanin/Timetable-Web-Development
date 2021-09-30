using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Timetable.DataAccessLayer;
using Timetable.Domains.Director;

namespace Timetable.Controllers
{
    //[Authorize(Roles = "Директор")]
    public class DirectorController : Controller
    {
        private IDirectorRepository _repository;
        private ApplicationDbContext _context;

        public DirectorController(IDirectorRepository repository, ApplicationDbContext context)
        {
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cabinets()
        {
            var model = _repository.Cabinets;
            return View(model);
        }

        public IActionResult Classes()
        {
            var model = _repository.Classes;
            return View(model);
        }

        public IActionResult Lessons()
        {
            var model = _repository.Lessons;
            return View(model);
        }

        public IActionResult Teachers()
        {
            var model = _repository.Teachers;
            return View(model);
        }

        public IActionResult Times()
        {

            var model = _repository.Times.OrderBy(time => time.Number);
            return View(model);
        }


        [Route("/Director/Cabinets/Edit/{id}",
            Name = "EditCabinet")]
        public IActionResult EditCabinet(int id)
        {
            var model = _repository.Cabinets.First(cab => cab.Id == id);
            return View(model);
        }

        [Route("/Director/Cabinets/Edit/{id}",
            Name = "EditCabinet")]
        [HttpPost]
        public IActionResult EditCabinet(Cabinet cabinet)
        {
            _context.Cabinets.Update(cabinet);
            _context.SaveChanges();
            return RedirectToAction("Cabinets");
        }

        [Route("/Director/Classes/Edit/{id}",
            Name = "EditClass")]
        public IActionResult EditClass(int id)
        {
            var model = _repository.Classes.First(cl => cl.Id == id);
            return View(model);
        }

        [Route("/Director/Classes/Edit/{id}",
            Name = "EditClass")]
        [HttpPost]
        public IActionResult EditClass(Class clas)
        {
            _context.Classes.Update(clas);
            _context.SaveChanges();
            return RedirectToAction("Classes");
        }

        [Route("/Director/Lessons/Edit/{id}",
            Name = "EditLesson")]
        public IActionResult EditLesson(int id)
        {
            var model = _repository.Lessons.First(les => les.Id == id);
            return View(model);
        }

        [Route("/Director/Lessons/Edit/{id}",
            Name = "EditLesson")]
        [HttpPost]
        public IActionResult EditLesson(Lesson lesson)
        {
            _context.Lessons.Update(lesson);
            _context.SaveChanges();
            return RedirectToAction("Lessons");
        }


        [Route("/Director/Teachers/Edit/{id}",
            Name = "EditTeacher")]
        public IActionResult EditTeacher(int id)
        {
            var model = _repository.Teachers.First(teacher => teacher.Id == id);
            return View(model);
        }

        [Route("/Director/Teachers/Edit/{id}",
            Name = "EditTeacher")]
        [HttpPost]
        public IActionResult EditTeacher(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
            return RedirectToAction("Teachers");
        }

        [Route("/Director/Times/Edit/{id}",
            Name = "EditTime")]
        public IActionResult EditTime(int id)
        {
            var model = _repository.Times.First(time => time.Id == id);
            return View(model);
        }

        [Route("/Director/Times/Edit/{id}",
            Name = "EditTime")]
        [HttpPost]
        public IActionResult EditTime(Time time)
        {
            _context.Times.Update(time);
            _context.SaveChanges();
            return RedirectToAction("Times");
        }

        public IActionResult AddCabinet()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCabinet(Cabinet cabinet)
        {
            if (ModelState.IsValid)
            {
                _context.Cabinets.Add(cabinet);
                await _context.SaveChangesAsync();
                return RedirectToAction("Cabinets");
            }

            return View(cabinet);
        }

        public IActionResult AddClass()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddClass(Class clas)
        {
            if (ModelState.IsValid)
            {
                _context.Classes.Add(clas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Classes");
            }

            return View(clas);
        }

        public IActionResult AddLesson()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddLesson(Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                _context.Lessons.Add(lesson);
                await _context.SaveChangesAsync();
                return RedirectToAction("Lessons");
            }

            return View(lesson);
        }

        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction("Teachers");
            }

            return View(teacher);
        }

        public IActionResult AddTime()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTime(Time time)
        {
            if (ModelState.IsValid)
            {
                _context.Times.Add(time);
                await _context.SaveChangesAsync();
                return RedirectToAction("Times");
            }

            return View(time);
        }

        public async Task<IActionResult> DeleteCabinet(int id)
        {
            var cabinet = await _context.Cabinets.FindAsync(id);
            if (cabinet != null)
            {
                _context.Cabinets.Remove(cabinet);
                await _context.SaveChangesAsync();

            }
            return RedirectToAction("Cabinets");
        }

        public async Task<IActionResult> DeleteClass(int id)
        {
            var clas = await _context.Classes.FindAsync(id);
            if (clas != null)
            {
                _context.Classes.Remove(clas);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Classes");
        }

        public async Task<IActionResult> DeleteLesson(int id)
        {
            var les = await _context.Lessons.FindAsync(id);
            if (les != null)
            {
                _context.Lessons.Remove(les);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Lessons");
        }

        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Teachers");
        }

        public async Task<IActionResult> DeleteTime(int id)
        {
            var time = await _context.Times.FindAsync(id);
            if (time != null)
            {
                _context.Times.Remove(time);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Times");
        }

    }
}
