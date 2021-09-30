using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.Domains.Director;

namespace Timetable.Domains.Headteacher
{
    public class TimetableHead
    {
        public int Id { get; set; }

        public string Class { get; set; }

        public string Cabinet { get; set; }

        public string timeStart { get; set; }

        public string timeEnd { get; set; }

        public string Teacher { get; set; }

        public string Lesson { get; set; }

        public string Day { get; set; }

    }
}
