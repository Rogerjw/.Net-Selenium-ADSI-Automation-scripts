using ADSAutomation.Pages;
using NUnit.Framework;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class ManageOrganizationTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageOrganizationPage _manageOrganizationPage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _manageOrganizationPage = new ManageOrganizationPage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
        }

        [SetUp]
        public void Before()
        {
            _manageOrganizationPage.GoToAdmin();
        }

        [Test(Description = "Verify if Admin >> Manage Organization link is clickable and navigates to Manage Organization page")]
        public void Verify_ManageOrganizationLink_ReturnsManageOrganizationPage()
        {
            Assert.AreEqual("Manage Organization", _manageOrganizationPage.GetHeader());
        }

        [Test(Description = "Verify if Organization is created without any data's provided")]
        public void Verify_OrganizationCannotBeCreated_WithoutData()
        {
            _manageOrganizationPage.ClickSubmit();
            Assert.IsTrue(_manageOrganizationPage.GetAlertText().Contains("Enter"));
            _manageOrganizationPage.ClickOkAlert();
        }

        [Test(Description = "Verify Manage Organization Functionality by providing only Mandatory Fields")]
        public void Verify_OrganizationCanBeCreated_WithOnlyMandatoryField()
        {
            _manageOrganizationPage.EnterBusiness("AAMCO Medical"+_manageOrganizationPage.GenerateRandomNumber());
            _manageOrganizationPage.ChooseState("Alaska");
            _manageOrganizationPage.EnterPhone("1234567890");
            _manageOrganizationPage.EnterAddress("234 ab");
            _manageOrganizationPage.EnterUrl("www.url.com");
            _manageOrganizationPage.EnterZipcode("555");
            _manageOrganizationPage.ChooseCity("Anchorage");
            _manageOrganizationPage.ClickSubmit();
            Assert.AreEqual("Inserted Successfully", _manageOrganizationPage.GetAlertText());
            _manageOrganizationPage.ClickOkAlert();
        }

        [Test(Description = "Verify if Duplicate Organization Name is allowed to submit")]
        public void Verify_DuplicateOrganization_CannotBeCreated()
        {
            _manageOrganizationPage.EnterBusiness("AAMCO Medical");
            _manageOrganizationPage.ChooseState("Alaska");
            _manageOrganizationPage.EnterPhone("1234567890");
            _manageOrganizationPage.EnterAddress("234 ab");
            _manageOrganizationPage.EnterUrl("www.url.com");
            _manageOrganizationPage.EnterZipcode("555");
            _manageOrganizationPage.ChooseCity("Anchorage");
            _manageOrganizationPage.ClickSubmit();
            _manageOrganizationPage.ClickOkAlert();
            _manageOrganizationPage.GoToAdmin();
            _manageOrganizationPage.EnterBusiness("AAMCO Medical");
            _manageOrganizationPage.ChooseState("Alaska");
            _manageOrganizationPage.EnterPhone("1234567890");
            _manageOrganizationPage.EnterAddress("234 ab");
            _manageOrganizationPage.EnterUrl("www.url.com");
            _manageOrganizationPage.EnterZipcode("555");
            _manageOrganizationPage.ChooseCity("Anchorage");
            _manageOrganizationPage.ClickSubmit();
            Assert.IsTrue(_manageOrganizationPage.GetAlertText().Contains("BussinessName already Exist"));
            _manageOrganizationPage.ClickOkAlert();
        }

        [Test(Description = "Verify Manage Organization Functionality by providing All Fields")]
        public void Verify_OrganizationCanBeCreated_WithAllFieldsProvided()
        {
            _manageOrganizationPage.EnterBusiness("AAMCO Medical" + _manageOrganizationPage.GenerateRandomNumber());
            _manageOrganizationPage.ChooseState("Alaska");
            _manageOrganizationPage.EnterPhone("1234567890");
            _manageOrganizationPage.EnterAddress("234 ab");
            _manageOrganizationPage.EnterUrl("www.url.com");
            _manageOrganizationPage.EnterZipcode("555");
            _manageOrganizationPage.ChooseCity("Anchorage");
            _manageOrganizationPage.EnterFax("1234567890");
            _manageOrganizationPage.ChooseLogo();
            _manageOrganizationPage.ChooseReportHeader();
            _manageOrganizationPage.EnterAcronym("AAA");
            _manageOrganizationPage.ChooseBrightTreeUser();
            _manageOrganizationPage.EnterBrightTreeNickname("ABB");
            _manageOrganizationPage.ChooseDataEntry();
            _manageOrganizationPage.ClickSubmit();
            Assert.AreEqual("Inserted Successfully", _manageOrganizationPage.GetAlertText());
            _manageOrganizationPage.ClickOkAlert();
        }

        [Test(Description = "Verify the Cancel button Functionality")]
        public void Verify_CancelButton_ClearsAllTheFields()
        {
            _manageOrganizationPage.EnterBusiness("AAMCO Medical AA");
            _manageOrganizationPage.ChooseState("Alaska");
            _manageOrganizationPage.EnterPhone("1234567890");
            _manageOrganizationPage.EnterAddress("234 ab");
            _manageOrganizationPage.EnterUrl("www.url.com");
            _manageOrganizationPage.EnterZipcode("555");
            _manageOrganizationPage.ChooseCity("Anchorage");
            _manageOrganizationPage.EnterFax("1234567890");
            _manageOrganizationPage.ChooseLogo();
            _manageOrganizationPage.ChooseReportHeader();
            _manageOrganizationPage.EnterAcronym("AAA");
            _manageOrganizationPage.ChooseBrightTreeUser();
            _manageOrganizationPage.EnterBrightTreeNickname("ABB");
            _manageOrganizationPage.ChooseDataEntry();
            _manageOrganizationPage.ClickCancel();
            Assert.IsTrue(_manageOrganizationPage.AreAllTextboxCleared());
        }

        [Test(Description = "Verify the Edit icon Functionality")]
        public void Verify_Organization_CanBeEditted()
        {
            _manageOrganizationPage.ClickEditButton();
            Assert.AreEqual(_manageOrganizationPage.GetBusinessName(), _manageOrganizationPage.GetTextBoxValue());
        }

        [Test(Description = "Verify the Update Functionality")]
        public void Verify_OrganizationDetails_CanBeUpdated()
        {
            _manageOrganizationPage.ClickEditButton();
            _manageOrganizationPage.EnterBusiness("AAMCO Medical" + _manageOrganizationPage.GenerateRandomNumber());
            _manageOrganizationPage.ChooseState("Alaska");
            _manageOrganizationPage.EnterPhone("1234567890");
            _manageOrganizationPage.EnterAddress("234 ab");
            _manageOrganizationPage.EnterUrl("www.url.com");
            _manageOrganizationPage.EnterZipcode("555");
            _manageOrganizationPage.ChooseCity("Anchorage");
            _manageOrganizationPage.EnterFax("1234567890");
            _manageOrganizationPage.ChooseLogo();
            _manageOrganizationPage.ChooseReportHeader();
            _manageOrganizationPage.EnterAcronym("AAA");
            _manageOrganizationPage.ChooseBrightTreeUser();
            _manageOrganizationPage.EnterBrightTreeNickname("ABB");
            _manageOrganizationPage.ChooseDataEntry();
            _manageOrganizationPage.ClickSubmit();
            Assert.AreEqual("Successfully Updated", _manageOrganizationPage.GetAlertText());
            _manageOrganizationPage.ClickOkAlert();
        }
    }
}
