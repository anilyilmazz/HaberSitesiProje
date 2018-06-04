using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.ByCode;

namespace HaberSitesi.Models
{
    public class Yazarlar
    {
        public virtual int Id { get; set; }
        public virtual string isim { get; set; }
        public virtual string sifre { get; set; }
        public virtual string email { get; set; }
    }

    public class YazarlarMap : ClassMapping<Yazarlar>
    {
        public YazarlarMap()
        {
            Table("Yazarlar");

            Id(x => x.Id, x => x.Generator(Generators.Identity));

            Property(x => x.isim);
            Property(x => x.sifre);
            Property(x => x.email);
        }


    }    
}