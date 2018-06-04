using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaberSitesi.ViewModels
{
    public class NewsAdd
    {

      
        [DisplayName("Id")]
        public int Id { get; set; }
      
        [DisplayName("Konu")]
        public string konu { get; set; }
     
        [DisplayName("Tarih")]
        public DateTime tarih { get; set; }
        
        [DisplayName("Haber İçeriği")]
        public string icerik { get; set; }

        [DisplayName("Kategori")]
        public string kategori { get; set; }
        
        [DisplayName("Resim")]
        public string resim { get; set; }
    }
}