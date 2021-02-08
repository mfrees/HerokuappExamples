using OpenQA.Selenium;
using System;

namespace HerokuappExamples
{
    internal class ABTestControlPO : BaseApplicationPage
    {
        public ABTestControlPO(IWebDriver driver) : base(driver) { }

        //Page Objects Below
        public IWebElement ABTestingLink => Driver.FindElement(By.LinkText("A/B Testing"));

        //Methods Below
        internal void VerifyText()
        {
            ABTestingLink.Click();
        }
    }
}