using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
<<<<<<< HEAD
        public string Test { get; set; }

        [Required]
        [Display(Prompt ="Username",Name ="Username:")]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]  // this is an annotation
=======
        public string userName { get; set; }
        [DataType(DataType.Password)]
>>>>>>> 0a1d628badccb48373ce9a4bc4af277aa194fdf5
        public string password { get; set; }
    }
}