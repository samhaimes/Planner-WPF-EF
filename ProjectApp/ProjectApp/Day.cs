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
        public DayOfWeek _dayofweek;
        List<DayOfWeek> TheDay = new List<DayOfWeek>();
        public int ActivitiesId { get; set; }
        public virtual Activities Activities { get; set; }

        public Day() { }

        public override string ToString()
        {
            return $"on {_dayofweek}";
        }


    }
}
