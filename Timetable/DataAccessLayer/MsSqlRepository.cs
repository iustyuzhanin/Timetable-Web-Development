using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Domains;
using Timetable.Domains.Director;
using Timetable.Domains.Headteacher;

namespace Timetable.DataAccessLayer
{
    public class MsSqlRepository:IDirectorRepository
    {
        private ApplicationDbContext _context;

        public MsSqlRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<TimetableHead> Timetables => _context.Timetables;

        public IQueryable<Day> Days => _context.Days;

        public IQueryable<Cabinet> Cabinets => _context.Cabinets;

        public IQueryable<Class> Classes => _context.Classes;

        public IQueryable<Lesson> Lessons => _context.Lessons;

        public IQueryable<Teacher> Teachers => _context.Teachers;

        public IQueryable<Time> Times => _context.Times;

    }
}
