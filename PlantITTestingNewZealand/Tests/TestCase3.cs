namespace PlantITTestingNewZealand.Tests
{

    public class TestCase3 : PlantITTestingNewZealand.BaseClass.BaseClass
    {

        [Test]
        public void Test3()
        {
            TestContext.WriteLine("Running Test 3");
            base.homePage.clickStartShopping();
            base.buyPage.addItemsToCart();
            base.buyPage.clickCart();
            base.checkoutPage.validateNumbersAndSums();
            Assert.Pass();
        }
    }


}
