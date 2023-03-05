using ADSAutomation.Pages;
using NUnit.Framework;


namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class ManageCityTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageCityPage _manageCityPage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _manageCityPage = new ManageCityPage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
        }

        [SetUp]
        public void Before()
        {
            _manageCityPage.GoToAdmin();
        }

        [Test(Description = "Verify if Admin >> Manage City link is clickable and navigates to Manage City page")]
        public void Verify_ManageCityLink_ReturnsManageCityPage()
        {
            Assert.AreEqual("Manage City", _manageCityPage.GetHeader());
        }

        [Test(Description = "Verify if City is created without any data's provided")]
        public void Verify_CityCannotBeCreated_WithoutData()
        {
            _manageCityPage.ClickSubmit();
            Assert.IsTrue(_manageCityPage.GetAlertText().Contains("Enter City"));
            _manageCityPage.ClickOkAlert();
        }

        [Test(Description = "Verify Manage Region Functionality by providing only Mandatory Fields")]
        public void Verify_CityCanBeCreated_WithOnlyMandatoryField()
        {
            _manageCityPage.ChooseState("Alaska");
            _manageCityPage.EnterCityName("a" + _manageCityPage.GenerateRandomNumber());
            _manageCityPage.ClickSubmit();
            Assert.AreEqual("Inserted Successfully", _manageCityPage.GetAlertText());
            _manageCityPage.ClickOkAlert();
        }

        [Test(Description = "Verify if Duplicate Name is allowed to submit")]
        public void Verify_DuplicateCities_CannotBeCreated()
        {
            _manageCityPage.ChooseState("Alaska");
            _manageCityPage.EnterCityName("Juneau");
            _manageCityPage.ClickSubmit();
            _manageCityPage.ClickOkAlert();
            _manageCityPage.ChooseState("Alaska");
            _manageCityPage.EnterCityName("Juneau");
            _manageCityPage.ClickSubmit();
            Assert.AreEqual("CityName already Exist", _manageCityPage.GetAlertText());
            _manageCityPage.ClickOkAlert();
        }

        [Test(Description = "Verify Manage State Functionality by providing All Fields")]
        public void Verify_CityCanBeCreated_WithAllFields()
        {
            _manageCityPage.ChooseState("Alaska");
            _manageCityPage.EnterCityName("a"+_manageCityPage.GenerateRandomNumber());
            _manageCityPage.ClickSubmit();
            Assert.AreEqual("Inserted Successfully", _manageCityPage.GetAlertText());
            _manageCityPage.ClickOkAlert();
        }

        [Test(Description = "Verify the Cancel button Functionality")]
        public void Verify_CancelButton_ClearsAllTheFields()
        {
            _manageCityPage.ChooseState("Alaska");
            _manageCityPage.EnterCityName("Juneau");
            _manageCityPage.ClickCancel();
            Assert.IsTrue(_manageCityPage.GetTextBoxValue().Equals(""));
        }

        [Test(Description = "Verify the Edit icon Functionality")]
        public void Verify_City_CanBeEditted()
        {
            _manageCityPage.ClickEditButton();
            Assert.AreEqual(_manageCityPage.GetFirstCellCityName() , _manageCityPage.GetTextBoxValue());
        }
        
        [Test(Description = "Verify the Update Functionality")]
        public void Verify_City_CanBeUpdated()
        {
            _manageCityPage.ClickEditButton();
            _manageCityPage.EnterCityName("a"+_manageCityPage.GenerateRandomNumber());
            _manageCityPage.ClickSubmit();
            Assert.AreEqual("Successfully Updated", _manageCityPage.GetAlertText());
            _manageCityPage.ClickOkAlert();
        }

    }
}
