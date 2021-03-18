using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace HerokuappExamples
{
    internal class ExitIntentModalPO : BaseApplicationPage
    {
        public ExitIntentModalPO(IWebDriver driver) : base(driver) { }

        public IWebElement ExitIntentLinkText => Driver.FindElement(By.LinkText("Exit Intent"));

        internal void  AcceptExitIntentModal()
        {
            ExitIntentLinkText.Click();

            try
            {
                IWebElement e = Driver.FindElement(By.LinkText("Elemental Selenium"));
                Actions action = new Actions(Driver);
                action.MoveToElement(e).MoveByOffset(600, -1).Build().Perform();
                Driver.FindElement(By.XPath(".//*[@id='ouibounce-modal']/div[2]/div[3]/p")).Click();
            } catch(OpenQA.Selenium.MoveTargetOutOfBoundsException) {
              return false;
            }
            
        }
    }
}