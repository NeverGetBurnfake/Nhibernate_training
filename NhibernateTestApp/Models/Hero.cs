using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateTestApp.Models
{
    class Hero
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Profession { get; set; }
        public virtual int HP { get; set; }
        public virtual int MP { get; set; }

    }
}
