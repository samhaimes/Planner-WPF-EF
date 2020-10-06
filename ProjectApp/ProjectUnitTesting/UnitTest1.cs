using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using ProjectModel;
using System.Threading;
using ProjectBusiness;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace ProjectUnitTesting
{
    public class Tests
    {
        CRUDManager _crudManager;

        [SetUp]
        public void Setup()
        {
            _crudManager = new CRUDManager();
        }
        [Test] //Test to see if it outputs the correct amount of activites from the table
        public void CheckHowManyActivitiesThereAre()
        {
            using (var db = new ProjectContext())
            {
                var CountActivities = db.GetActivities.Count();
                Assert.AreEqual(CountActivities, 5);

            }
    }
        //[Test] //Test to see if it works after adding an activity 
        //public void CheckIfItStillWorksAddingActivity()
        //{
        //    using (var db = new ProjectContext())
        //    {
        //        var CountActivitiesBefore = db.GetActivities.Count();
        //        _crudManager.CreateActivity("Golf", "09:00", "10:00");
        //        var CountActivitesAfter = db.GetActivities.Count();
        //        Assert.AreEqual(CountActivitiesBefore + 1, CountActivitesAfter);

        //    }
        //}

        [Test] //Test to see if it outputs the correct amount of family members from the table
        public void CheckHowManyMembersThereAre()
        {
            using (var db = new ProjectContext())
            {
                var CountFamilyMembers = db.FamilyMembers.Count();
                Assert.AreEqual(CountFamilyMembers, 4);

            }
        }

        [Test] //Test to see if it works after adding an another family member
        public void CheckIfItStillWorksAddingFamilyMember()
        {
            using (var db = new ProjectContext())
            {
                var CountFamilyBefore = db.FamilyMembers.Count();
                _crudManager.CreateMember("Heather", "Steel", "Adult", "Athlete");
                var CountFamilyAfter = db.FamilyMembers.Count();
                Assert.AreEqual(CountFamilyBefore + 1, CountFamilyAfter);

            }
        }

        //Test 1: Test that Full Name method is working 
        [TestCase("Sami", "Haimes", "Sami Haimes")]
        [TestCase("", "", " ")]
        public void FulNameTest(string FirstName, string LastName, string expected)
        {
            var subject = new FamilyMember(FirstName, LastName);
            var result = subject.FullName();
            Assert.AreEqual(expected, result);
        }

        ////Test 2 : Test that Activites To String method is working
        //[TestCase("Cycling", "10:00", "11:00", "Cycling")]
        //public void TestingActivitiesMethod(string Activity_, string StartTime_, string EndTime_, string expected)
        //{
        //    var subject = new Activities(Activity_, StartTime_, EndTime_);
        //    var result = subject.ToString();
        //    Assert.AreEqual(expected, result);
        //}



    }
}