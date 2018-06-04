using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaberSitesi.ViewModels
{
    public class RegisterAuth
    {
        [Required]
        [DisplayName("İsim")]
        public string isim { get; set; }


        [Required]
        [DisplayName("Kullanıcı E-mail")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Kullanıcı şifre")]
        [MinLength(3)]
        public string sifre { get; set; }



    }
}