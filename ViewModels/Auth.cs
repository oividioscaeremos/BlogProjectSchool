using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        public string userName { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}