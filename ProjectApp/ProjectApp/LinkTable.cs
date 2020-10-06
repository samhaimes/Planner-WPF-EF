using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Text;

namespace ProjectModel
{
   public class LinkTable
    {
        public LinkTable()
        {
            //Activities = new HashSet<Activities>();
            //Day = new HashSet<Day>();
            //FamilyMember = new HashSet<FamilyMember>();
        }


        [Key] public int LinkTableId { get; set; }
        public int ActivitiesId { get; set; }

        public int DayId { get; set; }
        public int FamilyMemberId { get; set; }

        public virtual Activities Activity { get; set; }
        public virtual Day Day { get; set; }
        public virtual FamilyMember FamilyMember { get; set; }

    }
    }

