using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Domains.Headteacher;

namespace Timetable.DataAccessLayer
{
    interface IHeadTeacherRepository
    {
        IQueryable<Day> Days { get; }

        IQueryable<TimetableHead> Timetables { get; }
    }
}
