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

        public void CreateActivity(string Activity, string ActivityDetails)
        {
            var newActivity = new Activities() { Activity = Activity, ActivityDetails = ActivityDetails };
            using (var db = new ProjectContext())
            {
                db.GetActivities.Add(newActivity);
                db.SaveChanges();
            }


        }

        public void DeleteActivity(string Activity)
        {
          var oldActivity = new Activities() { Activity = Activity};
            using (var db = new ProjectContext())
            {
                var SelectedActivity =
                    from a in db.GetActivities
                    where a.Activity == $"{oldActivity}"
                    select a;

                db.GetActivities.RemoveRange(SelectedActivity);
                db.SaveChanges();
            }


        }

        public string Event(string Activity, string ActivityDetails)
            { 
             return $"{Activity} Info: {ActivityDetails}";
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




        //public List<Days> RetrieveDays()
        //{
        //    using (var db = new ProjectContext())
        //    {

        //        return db.Days.ToList();
        //    }
        //}



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
