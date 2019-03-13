using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        public string Test { get; set; }

        [Required]
        [Display(Prompt ="Username",Name ="Username:")]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]  // this is an annotation
        public string password { get; set; }
    }
}