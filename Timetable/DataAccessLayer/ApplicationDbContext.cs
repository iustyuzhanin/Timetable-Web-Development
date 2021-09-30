using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Timetable.Domains;
using Timetable.Domains.Director;
using Timetable.Domains.Headteacher;
using Timetable.Models;

namespace Timetable.DataAccessLayer
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AppUserModel> Users { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<TimetableHead> Timetables { get; set; }
        public DbSet<Timetable.Models.AppUserLoginModel> AppUserLoginModel { get; set; }
        public DbSet<Timetable.Models.AppRoleCreateModel> AppRoleCreateModel { get; set; }
        public DbSet<Timetable.Models.AppUserCreateModel> AppUserCreateModel { get; set; }
        public DbSet<Timetable.Models.AppUserProfileModel> AppUserProfileModel { get; set; }

    }
}
