using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Timetable.Models
{
    public class AppUserModel:IdentityUser
    {
        public string PostAddress { get; set; }

        [Required]
        [Display(Name = "Должность")]
        public string Position { get; set; }

        [Required]
        [Display(Name = "ФИО")]
        public string FullName { get; set; }

    }
}
