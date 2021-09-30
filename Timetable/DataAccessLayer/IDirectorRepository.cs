using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Domains;
using Timetable.Domains.Director;

namespace Timetable.DataAccessLayer
{
    public interface IDirectorRepository
    {
        IQueryable<Cabinet> Cabinets { get; }
        IQueryable<Class> Classes { get; }
        IQueryable<Lesson> Lessons { get; }
        IQueryable<Teacher> Teachers { get; }
        IQueryable<Time> Times { get; }
    }
}
