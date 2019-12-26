using NHibernate.Cfg;
using System;
using NHibernate.Tool.hbm2ddl;
using NhibernateTestApp.Models;

namespace NhibernateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadNhibernateCfg();
            var repo = new HeroRepo();
            var warrior = new Hero
            {
                Name = "Ракли",
                Profession = "Горное дело",
                HP = 120,
                MP = 50
            };

            repo.Add(warrior);
            var someone = repo.GetHeroByHP(120);
            repo.Add(someone);
            someone.Name = "Волджин";
            someone.Profession = "Рыбак";
            repo.Update(someone);

        }

        public static void LoadNhibernateCfg()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Hero).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}
