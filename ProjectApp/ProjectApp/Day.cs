using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ProjectModel
{
    class Day
    {
        public DayOfWeek DayofWeek {get; set;}

        public virtual FamilyMember FamilyMemberId { get; set; }

        public virtual Activities Activity { get; set; }

        public void Day()
        {
            throw new System.NotImplementedException();
        }
    }
}
