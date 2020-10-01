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
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public Activities()
        { 

        }

        public Activities(string Activity_, string StartTime_, string EndTime_)
        {
            Activity = Activity_;
            StartTime = StartTime_;
            EndTime = EndTime_;
        }

        public string Event(string Activity_, string StartTime_, string EndTime_)
        {
                Activity = Activity_;
                StartTime = StartTime_;
                EndTime = EndTime_;
            return $"{Activity}: {StartTime} - {EndTime}";
        }
        public override string ToString() 
        {

            return $"{Activity}: {StartTime} - {EndTime}"; ; // from {StartTime} to {EndTime}"; // need to add before this the family member
        }


    } 

}
