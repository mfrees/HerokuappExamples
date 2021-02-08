using AutomationResources;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuappExamples
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        //This class holds the setup and teardown which can be used by each test class.
        [Description("Everything which runs before the tests get executed.")]
        [Author("Michael Rees")]
        [SetUp]
        public void SetupForEverySingleTestMethod()
        {
            var factory = new WebDriverFactory();
            //Driver = factory.Create(BrowserType.Edge);
            Driver = factory.Create(BrowserType.Chrome);

            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        [Description("Everything which runs after the test has executed.")]
        [Author("Michael Rees")]
        [TearDown]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}