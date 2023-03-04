using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using ADSAutomation.Pages;
using ADSAutomation.Utils;
using NUnit.Framework;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    public class ScheduleOximetryTest : MasterTest
    {
        private ScheduleOximetryPage _scheduleOximetryPage;

        [SetUp]
        public void Before()
        {
            _scheduleOximetryPage = new ScheduleOximetryPage(_driver);
        }

        [Test(Description = "To verify the schedule oximetry flow ")]
        public void TestValidUserLogin()
        {
            _scheduleOximetryPage.GoToScheduleOximetry();
            _scheduleOximetryPage.SearchPatient("Tagmuthu", "Krishnan");
            _scheduleOximetryPage.SelectGivenPatientRecord();
        }
    }
}
