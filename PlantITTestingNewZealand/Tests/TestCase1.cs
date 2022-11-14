namespace PlantITTestingNewZealand.Tests
{

    public class TestCase1 : PlantITTestingNewZealand.BaseClass.BaseClass
    {

        [Test]
        public void Test1()
        {
            TestContext.WriteLine("Running Test 1");
            base.homePage.clickOnContact();
            base.contactPage.clickSubmitButton();
            base.contactPage.validateErrors();
            base.contactPage.inputToFields(); // need input;
            base.contactPage.validateIfErrorsAreGone();
            Assert.Pass();
        }
    }


}
