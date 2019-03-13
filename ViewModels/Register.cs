using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class RegisterRegister
    {
        [Required]
        [Display(Prompt = "Name", Name = "Name :")]
        public string name { get; set; }

        [Required]
        [Display(Prompt = "Surname", Name = "Surname :")]
        public string surname { get; set; }

        [Required]
        [Display(Prompt = "example@yourdomain.com", Name = "E-Mail :")]
        public string email { get; set; }
        
    }
}