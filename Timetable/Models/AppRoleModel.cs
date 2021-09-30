using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Timetable.Models
{
    public class AppRoleModel:IdentityRole
    {
        [Required]
        [Display(Name = "Название роли")]
        public string RoleName { get; set; }
    }
}
