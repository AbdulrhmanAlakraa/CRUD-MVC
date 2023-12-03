﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_DAL.Models
{
	public class ApplicationUser:IdentityUser
	{
        [Required]
        public string FName { get; set; }

        [Required]
        public string LName { get; set; }

       
        public bool IsActive { get; set; }

    }
}