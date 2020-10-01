using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using ProjectModel;
using System.Threading;

namespace ProjectUnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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

        //Test 2 : Test that Activites To String method is working
        [TestCase("Cycling", "10:00", "11:00", "Cycling: 10:00 - 11:00")]
        public void TestingActivitiesMethod(string Activity_, string StartTime_, string EndTime_, string expected)
        {
            var subject = new Activities(Activity_, StartTime_, EndTime_);
            var result = subject.ToString();
            Assert.AreEqual(expected, result);
        }

        //Test 3 : Test that the list of Activites outputs correcty
        [TestCase(Program.activitesCount, 6)]   //WHY ISN'T THIS WORKING
        public void TestingActivitiesList(string Activity_, string StartTime_, string EndTime_, string expected)
        {
            var subject = new Activities(Activity_, StartTime_, EndTime_);
            var result = subject.ToString();
            Assert.AreEqual(expected, result);
        }

    }
}