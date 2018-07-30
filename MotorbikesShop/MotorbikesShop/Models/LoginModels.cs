using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotorbikesShop.Models
{
    public class LoginModels
    {
        [Required]
        public string TaiKhoan { set; get; }
        public string MatKhau { set; get; }
        
    }
}