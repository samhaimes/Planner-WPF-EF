using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectModel
{
    public class FamilyMember
    {

        public  FamilyMember()
        {
        }
        
        [Key]
        public int FamilyMemberId { get; set; }

        public string _FirstName;
        public string _LastName;
        public string _Stage;
        public string _Occupation;

        public override string ToString()
        {
            return $"{FullName()}";
        }

        public string FullName()
        { 
            return $"{_FirstName} {_LastName}"; // this could be split to a full name method and also add occupation
        }


    }
}
