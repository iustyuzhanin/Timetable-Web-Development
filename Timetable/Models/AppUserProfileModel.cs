using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.Models
{
    public class AppUserProfileModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Логин")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Должность")]
        public string Position { get; set; }

    }
}
