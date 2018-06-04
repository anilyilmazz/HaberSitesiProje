using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberSitesi.Models
{
    public class Haberler
    {
        public virtual int HaberId { get; set; }
        public virtual int Id { get; set; }
        public virtual string konu { get; set; }
        public virtual string icerik { get; set; }
        public virtual string resim { get; set; }
        public virtual string kategori { get; set; }
        public virtual DateTime tarih { get; set; }
    }
    public class HaberlerMap : ClassMapping<Haberler>
    {
        public HaberlerMap()
        {
            Table("Haberler");

            Id(x => x.HaberId, x => x.Generator(Generators.Identity));

            Property(x => x.icerik);
            Property(x => x.konu);
            Property(x => x.kategori);
            Property(x => x.resim);
            Property(x => x.tarih);
            Property(x => x.Id);
        }


    }
}