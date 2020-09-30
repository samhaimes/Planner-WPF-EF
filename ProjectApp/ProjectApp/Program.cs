using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ProjectModel;
using System.Collections.Generic;

namespace ProjectApp
{

    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FamilyMember Sami = new FamilyMember { FamilyMemberId = 1, _FirstName = "Sami", _LastName = "Haimes" };
            Activities Running = new Activities { ActivitiesId = 1, Activity = "Running" };
            Console.WriteLine($"{Sami.ToString()} {Running.ToString()}");
        }
    }
}
