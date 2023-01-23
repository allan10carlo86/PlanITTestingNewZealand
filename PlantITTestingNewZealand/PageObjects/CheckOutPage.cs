using System.Net.NetworkInformation;
using AventStack.ExtentReports;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using PlantITTestingNewZealand.PageObjects.BasePage;
using PlantITTestingNewZealand.Utilities;
using System.Collections;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace PlantITTestingNewZealand.PageObjects
{
    public class CheckOutPage : BaseAbstractPage
    {


        private Hashtable selectionOfItems;
        private IList<IWebElement> itemPrice_text;

        public CheckOutPage(IWebDriver driver) : base(driver)
        {
            selectionOfItems = new Hashtable();
            selectionOfItems.Add("Stuffed Frog", "2");
            selectionOfItems.Add("Fluffy Bunny", "5");
            selectionOfItems.Add("Valentine Bear", "3");
        }





        [FindsBy(How = How.XPath, Using = "//tbody/tr")]
        private IList<IWebElement> items;

        public void validateNumbersAndSums()
        {

            foreach(IWebElement element in items) {


                IList<IWebElement> childNodes = element.FindElements(By.XPath("./child::td"));
                List<String> listOfTexts = new List<String>();


                foreach (IWebElement childNode in childNodes) {
                    string message = childNode.Text;
                    ExtentTestManager.GetTest().Log(Status.Info, childNode.TagName);

                    if (message == null || message == "") {
                            IList<IWebElement> inputNodes = childNode.FindElements(By.XPath("./child::input"));
                            foreach (IWebElement inputElement in inputNodes)
                            {
                                message = inputElement.GetAttribute("value");
                            }

                    }

                    listOfTexts.Add(message);
                    logger.Info(message);
                    ExtentTestManager.GetTest().Log(Status.Info, message);

                   // *** Validate Sums HERE
                }
                

            }
        }

      
    }
}
