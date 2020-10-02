using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel
{
    public partial class ActivityDay 
    {
        public int ActivityDayId { get; set; }
        public Activities ActivitiesId { get; set; }
        public Day DayId { get; set; }
        public FamilyMember FamilyMemberId { get; set; }

    }
}
