using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel
{
    public class Activities
    {
        public int ActivitiesId { get; set; }
        public string Activity;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Activities() 
        {
          
        }

        public override string ToString() 
        {
            return $" is doing {Activity}"; // from {StartTime} to {EndTime}"; // need to add before this the family member
        }


    }
}
