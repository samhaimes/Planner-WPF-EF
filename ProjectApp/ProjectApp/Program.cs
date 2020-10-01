using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ProjectModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectApp
{

    class Program
    { 
                    public static int activitesCount()
               {
        var activities = new List<Activities>()
            {
                new Activities("Gym", "07:00", "08:00"),
                new Activities("Work", "09:00", "17:00"),
                new Activities("Dinner", "19:00", "18:00"),
                new Activities("Football", "11:00", "12:00"),
                new Activities("Painting", "09:00", "10:00"),
                new Activities("Doctors", "09:00", "09:15"),
            };
        { return activities.Count; }
    }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FamilyMember Sami = new FamilyMember { FamilyMemberId = 1, _FirstName = "Sami", _LastName = "Haimes" };
            Activities Running = new Activities { ActivitiesId = 1, Activity = "Running" };
            Console.WriteLine($"{Sami.ToString()} {Running.ToString()}");

            var activities = new List<Activities>()
            {
                new Activities("Gym", "07:00", "08:00"),
                new Activities("Work", "09:00", "17:00"),
                new Activities("Dinner", "19:00", "18:00"),
                new Activities("Football", "11:00", "12:00"),
                new Activities("Painting", "09:00", "10:00"),
                new Activities("Doctors", "09:00", "09:15"),
            };

            foreach (var a in activities)
            {
                Console.WriteLine(a);
            }

            var people = new List<FamilyMember>()
            {
                new FamilyMember("Sami", "Haimes"),
            new FamilyMember("Lydia", "Jones"),
            new FamilyMember("Mike", "Williams"),
            new FamilyMember("Rhian", "Meredith"),
            new FamilyMember("Hari", "Huws")
            };

            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }



        }

    }