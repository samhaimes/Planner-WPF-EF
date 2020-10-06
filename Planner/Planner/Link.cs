using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Planner
{
    public class Link
    {
        [Required]
        [DataMember(Name = "key")]
        [Key]
        public int LinkId { get; set; }


        [ForeignKey("Activities")]
        public int ActivitiesId { get; set; }

        [ForeignKey("Day")]
        public int DayId { get; set; }

        [ForeignKey("FamilyMember")]
        public int? FamilyMemberId { get; set; }

        [IgnoreDataMember]
        public virtual Day Day { get; set; }
        [IgnoreDataMember]
        public virtual Activities Activities { get; set; }
        [IgnoreDataMember]
        public virtual FamilyMember FamilyMember { get; set; }

        public override string ToString()
        {
            return $"{LinkId}";
        }

    }

}

