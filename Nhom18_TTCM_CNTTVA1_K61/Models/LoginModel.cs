using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nhom18_TTCM_CNTTVA1_K61.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Email")]
        public string userMail { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
    }
}