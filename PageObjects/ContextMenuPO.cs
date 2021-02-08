using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace HerokuappExamples
{
    internal class ContextMenuPO :BaseApplicationPage
    {
        public ContextMenuPO(IWebDriver driver) : base(driver) { }
        internal void VerifyPageSubHeader()
        {
            Driver.FindElement(By.LinkText("Context Menu")).Click();
        }

        internal void RightClickInHotSpotToTriggerAlert()
        {
            Driver.FindElement(By.LinkText("Context Menu")).Click(); //Selects Context Menu hyperlink from the home page
            IWebElement elem = Driver.FindElement(By.Id("hot-spot")); //Locates the right click hotspot
            Actions Builder = new Actions(Driver);
            Builder.ContextClick(elem).Perform(); //Right clicks in the hot spot

            IAlert a = Driver.SwitchTo().Alert();
            if (a.Text.Equals("You selected a context menu"))
            {
                a.Accept();
            }
            else
            {
                a.Dismiss();
            }
        }
    }
}