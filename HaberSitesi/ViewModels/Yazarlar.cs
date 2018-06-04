using HaberSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberSitesi.ViewModels
{
    public class YazarlarIndex
    {
        public IEnumerable<Yazarlar> Yazar { get; set; }
    }
}