using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaberSitesi.ViewModels
{
    public class Auth
    {

        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Kullanıcı E-mail")]
        public string email { get; set; }

        [Required]
        [DataType("password")]
        [DisplayName("Kullanıcı şifre")]
        [MinLength(3)]
        public string sifre { get; set; }


    }
}