using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_pg_192
{
    public class Weekday
    {
        public Day Day { get; set; }

    }
    public enum Day
    {
         Sunday,
         Monday,
         Tuesday,
         Wednesday,
         Thursday,
         Friday,
         Saturday

    }
}
