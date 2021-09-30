using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Timetable.Models
{
    public class AppRoleCreateModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название роли")]
        public string RoleName { get; set; }
    }
}
