using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberSitesi.Migrations
{
    [Migration(1)]
    public class _001_Tables : Migration
    {
        public override void Down()
        {
            Delete.Table("yazarlar");
            Delete.Table("haberler");
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("Yazarlar")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("isim").AsString()
                .WithColumn("sifre").AsString()
                .WithColumn("email").AsString();

            Create.Table("Haberler")
                .WithColumn("HaberId").AsInt32().Identity().PrimaryKey()
                .WithColumn("Id").AsInt32().ForeignKey("Yazarlar", "Id").OnDelete(System.Data.Rule.Cascade)
                .WithColumn("konu").AsString()
                .WithColumn("icerik").AsString()
                .WithColumn("resim").AsString()
                .WithColumn("kategori").AsString()
                .WithColumn("tarih").AsDateTime();
        }
    }
}