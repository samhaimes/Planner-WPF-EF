using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace ProjectModel
{
    public class Day
    {
        [Key]
        public int DayId { get; set; }

        public string _dayofweek { get; set;  }
        public int ActivitiesId { get; set; }
        public virtual Activities Activities { get; set; }

        public Day() { }
        public Day(string dayofweek)
        {
            _dayofweek = dayofweek;
        }

        public override string ToString()
        {
            return $"{_dayofweek}";
        }


    }
}
