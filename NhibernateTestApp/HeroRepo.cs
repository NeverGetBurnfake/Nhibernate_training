using NhibernateTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace NhibernateTestApp
{
    class HeroRepo
    {
        public void Add(Hero hero)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {
                using(ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(hero);
                    transaction.Commit();
                }
            }
        }

        public Hero GetHeroByHP(int Hp)
        {
            using(ISession session = NhibernateHelper.OpenSession())
            {
                var result = session.QueryOver<Hero>().Where(x => x.HP == Hp).SingleOrDefault();
                return result ?? new Hero();
            }
        }

        public void Update(Hero hero)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(hero);
                    transaction.Commit();
                }
            }
        }

        public void Delete(Hero hero)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(hero);
                    transaction.Commit();
                }
            }
        }
    }
}
