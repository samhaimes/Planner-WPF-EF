using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Planner
{
    public class FamilyMember
    {
        public int FamilyMemberId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Stage { get; set; }
        public FamilyMember()
        {
        }

        public FamilyMember(string _FirstName, string _LastName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
        }

        public override string ToString()
        {
            return $"{FullName()}";
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}"; // this could be split to a full name method and also add occupation
        }


    }
}
