using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSAlexander
{
    public class Schedule
    {
        public int _day { get; set; }
        public string _intime { get; set; }
        public string _outtime { get; set; }

        public Schedule (int dayofweek, string intime, string outtime)
        {
            _day = dayofweek;
            _intime = intime;
            _outtime = outtime;
        }
    }
}
