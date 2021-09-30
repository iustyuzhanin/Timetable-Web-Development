using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Timetable.Domains;
using Timetable.Domains.Director;

namespace Timetable.DataAccessLayer
{
    public class DataManager
    {
        public static void SeedData(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Cabinets.Any())
            {
                context.Cabinets.AddRange(
                    new Cabinet
                    {
                        Name = "1"
                    },
                    new Cabinet
                    {
                        Name = "2"
                    },
                    new Cabinet
                    {
                        Name = "3"
                    },
                    new Cabinet
                    {
                        Name = "4"
                    },
                    new Cabinet
                    {
                        Name = "5"
                    },
                    new Cabinet
                    {
                        Name = "6"
                    },
                    new Cabinet
                    {
                        Name = "7"
                    },
                    new Cabinet
                    {
                        Name = "8"
                    },
                    new Cabinet
                    {
                        Name = "9"
                    },
                    new Cabinet
                    {
                        Name = "10"
                    },
                    new Cabinet
                    {
                        Name = "11"
                    },
                    new Cabinet
                    {
                        Name = "12"
                    },
                    new Cabinet
                    {
                        Name = "13"
                    },
                    new Cabinet
                    {
                        Name = "14"
                    },
                    new Cabinet
                    {
                        Name = "15"
                    },
                    new Cabinet
                    {
                        Name = "16"
                    },
                    new Cabinet
                    {
                        Name = "17"
                    },
                    new Cabinet
                    {
                        Name = "18"
                    });
            }


            if (!context.Classes.Any())
            {
                context.Classes.AddRange(
                    new Class
                    {
                        Name = "5а"
                    },
                    new Class
                    {
                        Name = "5б"
                    },
                    new Class
                    {
                        Name = "6а"
                    },
                    new Class
                    {
                        Name = "6б"
                    },
                    new Class
                    {
                        Name = "7а"
                    },
                    new Class
                    {
                        Name = "7б"
                    },
                    new Class
                    {
                        Name = "8а"
                    },
                    new Class
                    {
                        Name = "8б"
                    },
                    new Class
                    {
                        Name = "9а"
                    },
                    new Class
                    {
                        Name = "9б"
                    },
                    new Class
                    {
                        Name = "10а"
                    },
                    new Class
                    {
                        Name = "10б"
                    },
                    new Class
                    {
                        Name = "11а"
                    },
                    new Class
                    {
                        Name = "11б"
                    });
            }

            if (!context.Lessons.Any())
            {
                context.Lessons.AddRange(
                    new Lesson()
                    {
                        Name = "Английский язык"
                    },
                    new Lesson()
                    {
                        Name = "Русский язык"
                    },
                    new Lesson()
                    {
                        Name = "Информатика"
                    },
                    new Lesson()
                    {
                        Name = "Математика"
                    },
                    new Lesson()
                    {
                        Name = "Биология"
                    },
                    new Lesson()
                    {
                        Name = "Химия"
                    },
                    new Lesson()
                    {
                        Name = "Физкультура"
                    },
                    new Lesson()
                    {
                        Name = "Физика"
                    },
                    new Lesson()
                    {
                        Name = "География"
                    },
                    new Lesson()
                    {
                        Name = "История"
                    },
                    new Lesson()
                    {
                        Name = "Обществознание"
                    },
                    new Lesson()
                    {
                        Name = "Литература"
                    });
            }

            if (!context.Teachers.Any())
            {
                context.Teachers.AddRange(
                    new Teacher()
                    {
                        Name = "Макарова Алиса Михаиловна"
                    },
                    new Teacher()
                    {
                        Name = "Веселова Элеонора Феликсовна"
                    },
                    new Teacher()
                    {
                        Name = "Крюкова Ольга Степановна"
                    },
                    new Teacher()
                    {
                        Name = "Гаврилова Наталия Федосеевна"
                    },
                    new Teacher()
                    {
                        Name = "Фролова Виктория Владимировна"
                    },
                    new Teacher()
                    {
                        Name = "Михайлова Юлия Геннадьевна"
                    },
                    new Teacher()
                    {
                        Name = "Хохлова Винетта Семёновна"
                    },
                    new Teacher()
                    {
                        Name = "Ларионова Александра Валерьяновна"
                    },
                    new Teacher()
                    {
                        Name = "Борисова Данна Рубеновна"
                    },
                    new Teacher()
                    {
                        Name = "Лаврентьева Арьяна Ивановна"
                    },
                    new Teacher()
                    {
                        Name = "Сафонова Мария Владимировна"
                    },
                    new Teacher()
                    {
                        Name = "Голубева Марина Аркадьевна"
                    });
            }

            if (!context.Times.Any())
            {
                context.Times.AddRange(
                 new Time
                 {
                     Number = 1,
                     StartTime = new DateTime(1, 1, 1, 8, 0, 0),
                     EndTime = new DateTime(1, 1, 1, 8, 45, 0)
                 },
                 new Time
                 {
                     Number = 2,
                     StartTime = new DateTime(1, 1, 1, 8, 50, 0),
                     EndTime = new DateTime(1, 1, 1, 9, 35, 0)
                 },
                 new Time
                 {
                     Number = 3,
                     StartTime = new DateTime(1, 1, 1, 9, 40, 0),
                     EndTime = new DateTime(1, 1, 1, 10, 25, 0)
                 },
                 new Time
                 {
                     Number = 4,
                     StartTime = new DateTime(1, 1, 1, 10, 30, 0),
                     EndTime = new DateTime(1, 1, 1, 11, 15, 0)
                 },
                 new Time
                 {
                     Number = 5,
                     StartTime = new DateTime(1, 1, 1, 11, 20, 0),
                     EndTime = new DateTime(1, 1, 1, 12, 05, 0)
                 },
                 new Time
                 {
                     Number = 6,
                     StartTime = new DateTime(1, 1, 1, 12, 20, 0),
                     EndTime = new DateTime(1, 1, 1, 13, 05, 0)
                 },
                 new Time
                 {
                     Number = 7,
                     StartTime = new DateTime(1, 1, 1, 13, 10, 0),
                     EndTime = new DateTime(1, 1, 1, 13, 55, 0)
                 },
                 new Time
                 {
                     Number = 8,
                     StartTime = new DateTime(1, 1, 1, 14, 0, 0),
                     EndTime = new DateTime(1, 1, 1, 14, 45, 0)
                 },
                 new Time
                 {
                     Number = 9,
                     StartTime = new DateTime(1, 1, 1, 14, 50, 0),
                     EndTime = new DateTime(1, 1, 1, 15, 35, 0)
                 },
                 new Time
                 {
                     Number = 10,
                     StartTime = new DateTime(1, 1, 1, 15, 40, 0),
                     EndTime = new DateTime(1, 1, 1, 16, 25, 0)
                 });
            }
            
            context.SaveChanges();
        }
    }
}
