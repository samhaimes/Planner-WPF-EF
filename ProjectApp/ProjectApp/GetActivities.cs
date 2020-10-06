using System;
using System.Collections.Generic;

namespace ProjectModel
{
    public partial class GetActivities
    {
        public GetActivities()
        {
           Days = new HashSet<Days>();
        }

        public int ActivitiesId { get; set; }
        public string Activity { get; set; }
        public string ActivityDetails { get; set; }

        public virtual ICollection<Days> Days { get; set; }
    }
}
