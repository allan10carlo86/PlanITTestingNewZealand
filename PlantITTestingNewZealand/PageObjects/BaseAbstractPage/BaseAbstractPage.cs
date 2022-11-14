using AventStack.ExtentReports;
using NLog;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using Logger = NLog.Logger;


namespace PlantITTestingNewZealand.PageObjects.BasePage
{
    public abstract class BaseAbstractPage
    {
        public IWebDriver driver;
        public static Logger logger;
        public WebDriverWait wait;
        public ExtentTest testExtent;

        public BaseAbstractPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
            logger = LogManager.GetCurrentClassLogger();
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(30));
            //testExtent = extentTest_param;
            logger = LogManager.GetCurrentClassLogger();
  
        }
    }
}