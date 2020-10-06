using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace ProjectModel
{
    public class Day
    { 
    public int DayId { get; set; }
        public string _dayofweek { get; set; }

        public Day() { }

        public Day(string dayOfWeek)
        {
            dayOfWeek = _dayofweek;
        }

        public override string ToString()
        {
            return $"{_dayofweek}";
        }
    }

}


