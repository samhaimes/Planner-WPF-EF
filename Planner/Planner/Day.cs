using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace Planner
{
    public class Day
    {
        public int DayId { get; set; }
        public string DayOfWeek { get; set; }

        public Day() { }

        public Day(string dayOfWeek)
        {
            DayOfWeek = dayOfWeek;
        }

        public override string ToString()
        {
            return $"{DayOfWeek}";
        }
    }

}


