using Model;
using NUnit.Framework;
using Planner;
using ProjectBusiness;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;

namespace ProjectUnitTest
{
    public class Tests
    {
        CRUDManager _crudManager = new CRUDManager();


        [SetUp]
        public void Setup()
        {
            _crudManager = new CRUDManager();
        }

        //Test for Creating an Activity and adding it to the database
        [Test]
        public void TestThatTheAddedActivityIsAlsoAddedToTheDatabase()
        {
            using var db = new ProjectContext();
            var createActivity = db.GetActivities.Count();
            _crudManager.CreateActivity("Painting", "Hillside Country Club");
            var withNewActivity = db.GetActivities.Count();
            Assert.AreEqual(createActivity + 1, withNewActivity);

        }

        // That that an Acitivty must have a name to be added to the database
        [Test]
        public void TestThatActivityMustHaveNameToBeAddedToTheDatabase()
        {

            using var db = new ProjectContext();
            var newAct = new Activities() {};
            db.GetActivities.Add(newAct);
            object actual = newAct.Activity;
            object expected = null;
            Assert.AreEqual(expected, actual);
         
        }

        //Testing for Deleting an Actvity from the database
        [Test]
        public void TestThatDeletingAnActivityAlsoDeletesFromDatabase()
        {
            using var db = new ProjectContext();
            var deleteActivity = db.GetActivities.Count();
            _crudManager.DeleteActivity("Painting");
            var withDeletedActivity = db.GetActivities.Count();
            db.SaveChanges();
            Assert.AreEqual(deleteActivity - 1, withDeletedActivity);

        }

        public void TestThatDeletingAnActivityThatDoesntExistWontWork()
        {
            using var db = new ProjectContext();
            var deleteActivity = db.GetActivities.Count();
            _crudManager.DeleteActivity("Table Tennis");
            Assert.Throws<ArgumentNullException>(() => _crudManager.DeleteActivity("Table Tennis"));
     

        }

        //Testing that Updating Activity Details also does on the database

        [Test]
        public void TestThatUpdatingActivityDetailWorks()
        { 

            using var db = new ProjectContext();
            {
                var selectedActivity =
                    (from a in db.GetActivities
                    where a.Activity == "Work"
                    select a.ActivityDetails).FirstOrDefault();

                
                string expected = "Changed to 8-4 for the next 6 weeks";
                string actual = selectedActivity.ToString();
                Assert.AreEqual(expected, actual);
            }

        }

        //Testing that Saving Activity on certain Day also does on the database
        [Test]
        public void TestThatSavingActivityOnCertainDayDoes()
        {

            using var db = new ProjectContext();
            var newActivity = new Activities() { Activity = "School" };
            var newDay = new Day() { DayOfWeek = "Sunday" };

            _crudManager.SaveActivityDay(newActivity, newDay, 1, 7);

            var checkSundaySchool = from l in db.Links
                                    where l.ActivitiesId == 1
                                    where l.DayId == 7
                                    select l;
            db.SaveChanges();
            Assert.IsNotNull(checkSundaySchool);
        }


        //Testing that I can delete a weekly activity 
        [Test]
        public void TestThatDeletingActivityOnCertainDayDoes()
        {
            using var db = new ProjectContext();
            var newActivity = new Activities() { Activity = "School" };
            var newDay = new Day() { DayOfWeek = "Sunday" };

            _crudManager.DeleteWeeklyActivity(newActivity, newDay, 7);

            var checkSundaySchool = from l in db.Links
                                    where l.ActivitiesId == 1
                                    where l.DayId == 7
                                    select l;
            db.SaveChanges();
            Assert.IsEmpty(checkSundaySchool);

        }

        //Testing that the list method that is used in the GUI contains all activities that are in
        // the database
        [Test]
        public void TestTheActivitesListIncludesAllActivitiesInDatabase()
        {
            using var db = new ProjectContext();
            var expected = _crudManager.RetrieveActivities().Count();
            var actual = db.GetActivities.Count();
            Assert.AreEqual(expected, actual);
        }

        //Testing that the list method that is used in the GUI contains all days that are in
        // the database
        [Test]
        public void TestTheActivitesListIncludesAllDaysInDatabase()
        {
            using var db = new ProjectContext();
            var expected = _crudManager.RetrieveDays().Count();
            var actual = db.Days.Count();
            Assert.AreEqual(expected, actual);
        }

        //Testing that the list method contains all family members that are in the database
        [Test]
        public void TestTheActivitesListIncludesAllMembersInDatabase()
        {
            using var db = new ProjectContext();
            var expected = _crudManager.RetrieveFamily().Count();
            var actual = db.FamilyMembers.Count();
            Assert.AreEqual(expected, actual);
        }

        //Testing set selected actvity method
        [Test]
        public void TestSetSelectedActivity()
        {
            using var db = new ProjectContext();
            Activities newActivity = new Activities() { Activity = "School" };
            _crudManager.SetSelectActivity(newActivity);
            var expected = _crudManager.SelectActivity.Activity;
            var actual = "School";
            Assert.AreEqual(expected, actual);
        }

        //Testing set selected family member method
        [Test]
        public void TestSetSelectedMemeber()
        {
            using var db = new ProjectContext();
            FamilyMember newMember = new FamilyMember() { FirstName = "Janie", LastName = "Wollaton" };
            _crudManager.SetSelectedMember(newMember);
            var expected = _crudManager.SelectedFamilyMember.ToString();
            var actual = "Janie Wollaton";
            Assert.AreEqual(expected, actual);
        }

        //Testing set selected  day method
        [Test]
        public void TestSetSelectedDay()
        {
            using var db = new ProjectContext();
            Day newDay = new Day() { DayOfWeek = "Monday" };
            _crudManager.SetSelectedDay(newDay);
            var expected = _crudManager.SelectedDay.DayOfWeek;
            var actual = "Monday";
            Assert.AreEqual(expected, actual);
        }

    }

}