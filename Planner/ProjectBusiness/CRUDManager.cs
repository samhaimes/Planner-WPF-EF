using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Model;
using Planner;

namespace ProjectBusiness
{
    public class CRUDManager
    {
        public FamilyMember SelectedFamilyMember { get; set; }
        public Activities SelectActivity { get; set; }
        public Day SelectedDay { get; set; }
        public Link NewWeeklyPlan { get; set; }

        public List<string> weeklyMon = new List<string>();
        public List<string> weeklyTues = new List<string>();
        public List<string> weeklyWed = new List<string>();
        public List<string> weeklyThurs = new List<string>();
        public List<string> weeklyFri = new List<string>();
        public List<string> weeklySat = new List<string>();
        public List<string> weeklySun = new List<string>();

        
         int x = 10;

        // Next Sprint of the Project would be to add the Family Member Class and use this method 
        public void CreateMember(string FirstName, string LastName, string Stage)
        {
            var newMember = new FamilyMember() { FirstName = FirstName, LastName = LastName, Stage = Stage };
            using var db = new ProjectContext();
            db.FamilyMembers.Add(newMember);
            db.SaveChanges();
        }


        public void CreateActivity(string Activity, string ActivityDetails)
        {
            var newActivity = new Activities() { Activity = Activity, ActivityDetails = ActivityDetails };
            using var db = new ProjectContext();
            db.GetActivities.Add(newActivity);
            db.SaveChanges();


        }

        public void DeleteActivity(string Activity)
        {
            var oldActivity = new Activities() { Activity = Activity };
            using var db = new ProjectContext();
            var SelectedActivity =
                from a in db.GetActivities
                where a.Activity == $"{oldActivity}"
                select a;

            db.GetActivities.RemoveRange(SelectedActivity);
            db.SaveChanges();
        }

        public void ChangeActivityDetail(string Activity, string ActivityDetail)
        {
            using var db = new ProjectContext();
            SelectActivity = db.GetActivities.Where(a => a.Activity == Activity).FirstOrDefault();
            SelectActivity.ActivityDetails = ActivityDetail;
            db.SaveChanges();
        }

        public void SaveActivityDay(object ActivityObject, object DayObject, int ActivitiesId, int DayId) //change to objects activityobject, 
        {

            ActivityObject = (Activities)ActivityObject;
            DayObject = (Day)DayObject;
            using var db = new ProjectContext();
            var NewPlan = from l in db.Links
                          join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                          join d in db.Days on l.DayId equals d.DayId
                          where ActivitiesId == SelectActivity.ActivitiesId
                          where DayObject == SelectedDay
                          select new
                          {
                              l.ActivitiesId,
                              l.DayId,
                              a.Activity,
                              d.DayOfWeek

                          };
            var newActDay = new Link() { ActivitiesId = ActivitiesId, DayId = DayId, FamilyMemberId = 0 };
            db.Links.Add(newActDay);
            db.SaveChanges();

        }

        public List<string> WeeklyActivity(int DayId)
        {
            using var db = new ProjectContext();

            if (DayId == 1)
            {
                var monday = from l in db.Links
                             join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                             where l.DayId == 1
                             select a.Activity;
                foreach (string s in monday)
                {
                    weeklyMon.Add(s);
                }
                return weeklyMon;
            }
            else if (DayId == 2)
            {
                var tuesday = from l in db.Links
                              join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                              where l.DayId == 2
                              select a.Activity;
                foreach (string s in tuesday)
                {
                    weeklyTues.Add(s);
                }
                return weeklyTues;
            }
            else if (DayId == 3)
            {
                var wednesday = from l in db.Links
                                join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                                where l.DayId == 3
                                select a.Activity;
                foreach (string s in wednesday)
                {

                    weeklyWed.Add(s);
                }
                return weeklyWed;
            }
            else if (DayId == 4)
            {
                var thursday = from l in db.Links
                               join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                               where l.DayId == 4
                               select a.Activity;
                foreach (string s in thursday)
                {
                    weeklyThurs.Add(s);
                }
                return weeklyThurs;
            }
            else if (DayId == 5)
            {
                var friday = from l in db.Links
                             join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                             where l.DayId == 5
                             select a.Activity;
                foreach (string s in friday)
                {

                    weeklyFri.Add(s);
                }
                return weeklyFri;
            }
            else if (DayId == 6)
            {
                var saturday = from l in db.Links
                               join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                               where l.DayId == 6
                               select a.Activity;
                foreach (string s in saturday)
                {

                    weeklySat.Add(s);
                }
                return weeklySat;
            }
            else //if (DayId == 7)

            {
                var sunday = from l in db.Links
                             join a in db.GetActivities on l.ActivitiesId equals a.ActivitiesId
                             where l.DayId == 7
                             select a.Activity;
                foreach (string s in sunday)
                {

                    weeklySun.Add(s);
                }
                return weeklySun;

            }
        }

        public void DeleteWeeklyActivity(object ActivityObject, object DayObject, int DayId)
        {
            //ActivityObject = (Activities)ActivityObject;
            //DayObject = (Day)DayObject;

            using var db = new ProjectContext();

            var oldWeeklyActivity = new Activities() { Activity = ActivityObject.ToString() };

            var selectact = (from a in db.GetActivities
                             where a.Activity == oldWeeklyActivity.ToString()
                             select a.ActivitiesId).FirstOrDefault();

            int activityid = Convert.ToInt32(selectact);

            var OldPlan = (from l in db.Links
                          where l.ActivitiesId == activityid && l.DayId == DayId
                          select l);


            db.Links.RemoveRange(OldPlan);
            db.SaveChanges();

        }

        public List<FamilyMember> RetrieveFamily()
                {
            using var db = new ProjectContext();
            
            return (db.FamilyMembers.ToList());
        }
        public List<Activities> RetrieveActivities()
                {
            using var db = new ProjectContext();
            return db.GetActivities.ToList();
        }
        public List<Day> RetrieveDays()
                {
            using var db = new ProjectContext();
            return db.Days.ToList();
        }


        public void SetSelectedMember(object selectedItem)
                {
                    SelectedFamilyMember = (FamilyMember)selectedItem;
                }
        public void SetSelectActivity(object selectedItem)
                {
                    SelectActivity = (Activities)selectedItem;
                }
        public void SetSelectedDay(object selectedItem)
                {
                    SelectedDay = (Day)selectedItem;
                }

        static void Main(string[] args)
                {
                    Console.WriteLine("Hello World!");
                    
                }


        
    }
}