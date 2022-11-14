using System.Net.NetworkInformation;
using AventStack.ExtentReports;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using PlantITTestingNewZealand.PageObjects.BasePage;
using PlantITTestingNewZealand.Utilities;

namespace PlantITTestingNewZealand.PageObjects
{
    public class HomePage : BaseAbstractPage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='#/contact']")]
        private IWebElement contact_link;
        private By contact_link_by = By.XPath("//a[@href='#/contact']");


        public void clickOnContact()
        {
            TestContext.WriteLine("Run clickOnContact");
            base.wait.Until(ExpectedConditions.ElementIsVisible(contact_link_by));
            contact_link.Click();
            ExtentTestManager.GetTest().Log(Status.Pass, "Clicked on the Contact Link");
        }
    }
}
