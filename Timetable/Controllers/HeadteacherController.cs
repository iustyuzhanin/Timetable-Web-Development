using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Timetable.DataAccessLayer;
using Timetable.Domains.Director;
using Timetable.Domains.Headteacher;

namespace Timetable.Controllers
{
    public class HeadteacherController : Controller
    {
        private IDirectorRepository _repository;
        private ApplicationDbContext _context;

        private static string className;
        private static string cabinetName;
        private static string lessonName;
        private static string teacherName;
        private static string timeNameStart;
        private static string timeNameEnd;
        private static string dayName;

        public HeadteacherController(IDirectorRepository repository, ApplicationDbContext context)
        {
            _repository = repository;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Class()
        {
            List<Class> listClasses = _context.Classes.ToList();
            return View(listClasses);
        }

        public async Task<IActionResult> Day(int id)
        {
            Class clas = await _context.Classes.FindAsync(id);
            className = clas.Name;

            ViewData["Name"] = className;

            List<Day> listDays = _context.Days.ToList();
            return View(listDays);
        }

        public async Task<IActionResult> Lesson(int id)
        {
            Day day = await _context.Days.FindAsync(id);
            dayName = day.Name;

            ViewData["Name"] = dayName;
            List<Lesson> listLessons = _context.Lessons.ToList();
            return View(listLessons);
        }

        public async Task<IActionResult> Teacher(int id)
        {
            Lesson lesson = await _context.Lessons.FindAsync(id);
            lessonName = lesson.Name;

            ViewData["Name"] = lessonName;
            List<Teacher> listTeachers = _context.Teachers.ToList();
            return View(listTeachers);
        }

        public async Task<IActionResult> Cabinet(int id)
        {
            Teacher teacher = await _context.Teachers.FindAsync(id);
            teacherName = teacher.Name;

            ViewData["Name"] = lessonName;
            List<Cabinet> listCabinets = _context.Cabinets.ToList();
            return View(listCabinets);
        }

        public async Task<IActionResult> Time(int id)
        {
            Cabinet cabinet = await _context.Cabinets.FindAsync(id);
            cabinetName = cabinet.Name;

            ViewData["Name"] = lessonName;
            List<Time> listTimes = _context.Times.OrderBy(time => time.Number).ToList();
            return View(listTimes);
        }

        public async Task<IActionResult> TimetableHead(int id)
        {
            Time time = await _context.Times.FindAsync(id);
            timeNameStart = time.StartTime.TimeOfDay.ToString();
            timeNameEnd = time.EndTime.TimeOfDay.ToString();

            ViewData["timeNameStart"] = timeNameStart;
            ViewData["timeNameEnd"] = timeNameEnd;
            ViewData["cabinetName"] = cabinetName;
            ViewData["teacherName"] = teacherName;
            ViewData["lessonName"] = lessonName;
            ViewData["className"] = className;
            ViewData["dayName"] = dayName;

            TimetableHead timetable = new TimetableHead
            {
                timeStart = timeNameStart,
                timeEnd = timeNameEnd,
                Class = className,
                Cabinet = cabinetName,
                Teacher = teacherName,
                Lesson = lessonName,
                Day = dayName
            };



            await _context.Timetables.AddAsync(timetable);
            await _context.SaveChangesAsync();

            return View();
        }
    }
}
