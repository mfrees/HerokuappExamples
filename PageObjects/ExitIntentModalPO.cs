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

        
        internal void ClickExitIntentLinkText()
        {
            ExitIntentLinkText.Click();
        }

        internal void AcceptExitIntentModal()
         {
            //IWebElement e = Driver.FindElement(By.LinkText("Elemental Selenium"));   //This method doesn't work, I need to find a different implementation to move the cursor outside the web browser pane.
            //Actions action = new Actions(Driver);
           //action.MoveToElement(e).MoveByOffset(600, 0).Build().Perform();
            //Driver.FindElement(By.XPath(".//*[@id='ouibounce-modal']/div[2]/div[3]/p")).Click();
        }
    }
}
