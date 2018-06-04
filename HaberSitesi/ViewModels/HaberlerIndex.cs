using HaberSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberSitesi.ViewModels
{
    public class HaberlerIndex
    {
        public IEnumerable<Haberler> Haber { get; set; }
    }
}