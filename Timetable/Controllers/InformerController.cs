using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.DataAccessLayer;
using Timetable.Domains.Headteacher;

namespace Timetable.Controllers
{
    public class InformerController : Controller
    {
        private IDirectorRepository _repository;
        private ApplicationDbContext _context;

        private static string className;
        private static string dayName;

        public InformerController(ApplicationDbContext context, IDirectorRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<string> classes = new List<string>();
            IEnumerable<TimetableHead> timetable = _context.Timetables;

            foreach (var time in timetable)
            {
                classes.Add(time.Class);
            }

            var clases = classes.Distinct();
          
            return View(clases);
        }

        public IActionResult Day(string name)
        {
            List<Day> days = _context.Days.ToList();
            //TimetableHead time = await _context.Timetables.FindAsync(id);
            className = name;

            ViewData["className"] = className;
            return View(days);
        }

        public IActionResult TimetableFinal(string name)
        {
            dayName = name;
            IEnumerable<TimetableHead> timetable = _context.Timetables
                .Where(t => t.Class == className && t.Day == dayName)
                .OrderBy(num => num.timeStart);

            ViewData["dayName"] = dayName;
            ViewData["className"] = className;
            return View(timetable);
        }
    }
}
