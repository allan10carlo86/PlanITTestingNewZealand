namespace PlantITTestingNewZealand.Tests
{

    public class TestCase2 : PlantITTestingNewZealand.BaseClass.BaseClass
    {

        [Test]
        public void Test2()
        {
            TestContext.WriteLine("Running Test 1");
            base.homePage.clickOnContact();
            base.contactPage.inputToFields(); // need input;
            base.contactPage.clickSubmitButton();
            base.contactPage.validateSuccessContactMessage();
            Assert.Pass();
        }
    }


}
