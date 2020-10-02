using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel
{
    public class Activities
    {
        public int ActivitiesId { get; set; }
        public string Activity { get; set; }
        public string ActivityDetails { get; set; }

        public Activities()
        { 
        }

        public Activities(string Activity_, string ActivityDetails_)
        {
            Activity = Activity_;
            ActivityDetails = ActivityDetails_;
        }

        public override string ToString()
        {

            return $"{Activity}"; // need to add before this the family member
        }




    }

}
