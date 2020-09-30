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
        public int DayId { get; set;}

        public DayOfWeek _dayofweek;
        public int ActivitiesId { get; set; }
        public virtual Activities Activities { get; set; }

        public Day() { }

    }
}
