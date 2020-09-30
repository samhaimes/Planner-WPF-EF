using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using ProjectModel;

namespace ProjectBusiness
{
    public class CRUDManager
    {
        public FamilyMember SelectedFamilyMember { get; set; }
        public Activities SelectActivity { get; set; }


        public void CreateMember(int FamilyMemberId, string FirstName, string LastName, string Stage, string Occupation)
        {
            var newMember = new FamilyMember() { FamilyMemberId = FamilyMemberId, _FirstName = FirstName, _LastName = LastName, _Stage = Stage, _Occupation = Occupation };
            using (var db = new ProjectContext())
            {
                db.FamilyMembers.Add(newMember);
                db.SaveChanges();
            }
        }

        public void CreateActivity(int ActivityId, string Activity, DateTime StartTime, DateTime EndTime)
        {
            var newActivity = new Activities() { ActivitiesId = ActivityId, Activity = Activity, StartTime = StartTime, EndTime = EndTime };
            using (var db = new ProjectContext())
            {
                db.GetActivities.Add(newActivity);
                db.SaveChanges();
            }


        }

        // create a method that takes the person the activity and the time 
        public void Action(int FirstName, int SecondName, int Activity redhg )
        { 
        
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
