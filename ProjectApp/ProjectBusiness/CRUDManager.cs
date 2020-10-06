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
        public LinkTable activityDay { get; set; }

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
       // public void CreateActivityDay(int )

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

        public void ChangeActivityDetail(string Activity, string ActivityDetail)
        {
            //var ActivityD = new Activities() { ActivityDetails = ActivityDetail };
            using (var db = new ProjectContext())
            { 
            SelectActivity = db.GetActivities.Where(a => a.Activity == Activity).FirstOrDefault();
            SelectActivity.ActivityDetails = ActivityDetail;
            db.SaveChanges();
            }
        }

        //public void ActivityDaySave()
        //{
        //    using (var db = new ProjectContext())
        //    {
        //        var SavePlan = 
        //        from a in db.GetActivities
        //        join l in db.linkTable on a.ActivitiesId equals l.ActivitiesId
        //        join  d in db.Days on l.DayId equals d.DayId
        //        where 
        //    }
        //}
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

        public void SetSelectedDay(object selectedItem)
        {
            SelectedDay = (Day)selectedItem;
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
