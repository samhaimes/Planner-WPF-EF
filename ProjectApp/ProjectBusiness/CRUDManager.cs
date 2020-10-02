using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using ProjectModel;

namespace ProjectBusiness
{
    public class CRUDManager
    {
        public FamilyMember SelectedFamilyMember { get; set; }
        public Activities SelectActivity { get; set; }
        public Day SelectedDay { get; set; }

        public void CreateMember(string FirstName, string LastName, string Stage, string Occupation)
        {
            var newMember = new FamilyMember() {_FirstName = FirstName, _LastName = LastName, _Stage = Stage, _Occupation = Occupation };
            using (var db = new ProjectContext())
            {
                db.FamilyMembers.Add(newMember);
                db.SaveChanges();
            }
        }

        public void CreateActivity(string Activity, string StartTime, string EndTime)
        {
            var newActivity = new Activities() { Activity = Activity, StartTime = StartTime, EndTime = EndTime };
            using (var db = new ProjectContext())
            {
                db.GetActivities.Add(newActivity);
                db.SaveChanges();
            }


        }

        public void Delete()
        { }

        public List<FamilyMember> RetrieveFamily()
        {
            using (var db = new ProjectContext())
            {
                return db.FamilyMembers.ToList();
            }
        }

        public List<Activities> RetrieveActivities()
        {
            using (var db = new ProjectContext())
            {
                return db.GetActivities.ToList();
            }
        }




        public List<Day> RetrieveDays()
        {
            using (var db = new ProjectContext())
            {

                return db.Days.ToList();
            }
        }



        //public List<Day> RetrieveDays()
        //{
        //    var daylist = new List<Day>();
        //    new Day("Monday");
        //    new Day("Tuesday");
        //    new Day("Wednesday");
        //    new Day("Thursday");
        //    new Day("Friday");
        //    new Day("Saturday");
        //    new Day("Sunday");
        //    return daylist;
        //}



        // create a method that takes the person the activity and the time 
        public string Action(string Activity, DateTime StartTime, DateTime EndTime)
        {
            using (var db = new ProjectContext())
            return $"{Activity}: {StartTime} - {EndTime}";
        }

        public void SetSelectActivity(object selectedItem)
        {
            SelectActivity = (Activities)selectedItem;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
